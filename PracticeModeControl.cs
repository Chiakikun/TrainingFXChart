// 練習モード用コントロール
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainingFXChart
{
    public partial class PracticeModeControl : UserControl
    {
        // 新規|決済, 日時, 売|買, 数量, 約定価格, 損益
        List<Tuple<string, string, string, string, string, string>> _orderlog = new List<Tuple<string, string, string, string, string, string>>();

        string _orderlogfile;
        int _intervalseconds;

        /// <summary>
        /// 練習モードの終了を通知する
        /// </summary>
        public Action SendPracticeModeFinish;


        /// <summary>
        /// 他のコントロールに、指定したインデックス番号をセットする
        /// </summary>
        public Action<int> SetCurrentIndex;


        /// <summary>
        /// ChartCanvasが今表示している一番右のローソクを取得する
        /// </summary>
        public Func<double[]> GetCandle; 


        public PracticeModeControl()
        {
            InitializeComponent();
            AddNewOrderTableRow(); // 新規注文用の空の行
        }


        public void Setting(SettingDialog sd)
        {
            _orderlogfile = sd.OrderLogFile;
            _intervalseconds = sd.IntervalSeconds * 1000;
        }


        /// <summary>
        /// 練習モード開始時に、その時表示されている一番右のローソクのインデックスがセットされ
        /// 以降はIncButton押下する度に+1される
        /// </summary>
        public int IdxCurrent
        {
            set; get;
        }


        /// <summary>
        /// 現在の注文状況を取得する
        /// </summary>
        public Tuple<string, double>[] GetOrder() // 売|買 注文価格
        {
            List<Tuple<string, double>> result = new List<Tuple<string, double>>();

            for (int i = 0; i < OrderTable.Rows.Count; i++)
            {
                string ordertype = OrderTable.Rows[i].Cells["Order"].Value.ToString();

                double ordervalue;
                if (!double.TryParse(OrderTable.Rows[i].Cells["OrderValue"].Value.ToString(), out ordervalue))
                    ordervalue = -1;

                result.Add(new Tuple<string, double>(ordertype, ordervalue));
            }

            return result.ToArray();
        }


        /// <summary>
        /// 現在の建玉と、その決済注文状況を取得する
        /// </summary>
        public Tuple<string, double, double, double>[] GetPosition() // 売|買 建玉 利確 損切
        {
            List<Tuple<string, double, double, double>> result = new List<Tuple<string, double, double, double>>();

            for (int i = 0; i < PositionTable.Rows.Count; i++)
            {
                string postype = PositionTable.Rows[i].Cells["Position"].Value.ToString();

                double posvalue;
                if (!double.TryParse(PositionTable.Rows[i].Cells["Value"].Value.ToString(), out posvalue))
                    posvalue = -1;

                double rikaku;
                if (!double.TryParse(PositionTable.Rows[i].Cells["OrderSashineValue"].Value.ToString(), out rikaku))
                    rikaku = -1;

                double sonkiri;
                if (!double.TryParse(PositionTable.Rows[i].Cells["OrderGyakuSashineValue"].Value.ToString(), out sonkiri))
                    sonkiri = -1;


                result.Add(new Tuple<string, double, double, double>(postype, posvalue, rikaku, sonkiri));
            }

            return result.ToArray();
        }


        /// <summary>
        /// キャンバスに表示されている足を1本分進め、注文の処理も行う。
        /// </summary>
        private void IncButton_Click(object sender, EventArgs e)
        {
            // キャンバスの足を1本進める
            double[] oldCandle = GetCandle();
            SetCurrentIndex(IdxCurrent += 1);
            double[] currentcandle = GetCandle();

            // これ以上進めないので、現在の建玉を全決済してモード終了
            if (oldCandle[0] == currentcandle[0])
            {
                for (int i = PositionTable.Rows.Count - 1; i >= 0; i--)
                {
                    PositionTable.Rows[i].Cells["Value"].Value = currentcandle[Const.IDXCL];
                    PositionTable.Rows[i].Cells["DateTime"].Value = FormatDate(currentcandle[Const.IDXDATE]);
                    LogAdd("決済", i);
                    PositionTable.Rows.RemoveAt(i);
                }
                CloseButton_Click(this, e);
            }

            //
            // 新規注文
            //
            int cnt = OrderTable.RowCount - 1; // 空行分-1
            for (int i = cnt - 1; i >= 0; i--)
            {
                double ordervalue = 0;
                if (!double.TryParse(OrderTable.Rows[i].Cells["OrderValue"].Value.ToString(), out ordervalue)) continue;
                double ordernum = 0;
                if (!double.TryParse(OrderTable.Rows[i].Cells["OrderNumber"].Value.ToString(), out ordernum)) continue;

                // 買えるかな？
                if (OrderTable.Rows[i].Cells["Order"].Value.ToString() == "買")
                {
                    if (ordervalue >= currentcandle[Const.IDXLW])
                        NewOrder(i, "買", ordernum, ordervalue > currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue, currentcandle);
                }
                // 売れるかな？
                else
                {
                    if (ordervalue <= currentcandle[Const.IDXHI])
                        NewOrder(i, "売", ordernum, ordervalue < currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue, currentcandle);
                }
            }

            //
            // 決済注文
            //
            cnt = PositionTable.RowCount;
            for (int i = cnt - 1; i >= 0; i--)
            {
                double value = double.Parse(PositionTable.Rows[i].Cells["Value"].Value.ToString());
                double number= double.Parse(PositionTable.Rows[i].Cells["Number"].Value.ToString()) * 10000;

                double ordervalue = 0;
                // 買いポジが...
                if (PositionTable.Rows[i].Cells["Position"].Value.ToString() == "買")
                {
                    // 狩られるか？
                    if (double.TryParse(PositionTable.Rows[i].Cells["OrderGyakuSashineValue"].Value.ToString(), out ordervalue))
                        if (ordervalue >= currentcandle[Const.IDXLW])
                        {
                            double yakujo = ordervalue > currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue;
                            RevOrder(i, yakujo, number, yakujo - value, currentcandle);
                            continue;
                        }
                    // 利確できるか？
                    if (double.TryParse(PositionTable.Rows[i].Cells["OrderSashineValue"].Value.ToString(), out ordervalue))
                        if (ordervalue <= currentcandle[Const.IDXHI])
                        {
                            double yakujo = ordervalue < currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue;
                            RevOrder(i, yakujo, number, yakujo - value, currentcandle);
                            continue;
                        }

                    PositionTable.Rows[i].Cells["SonEki"].Value = ((currentcandle[Const.IDXCL] - value) * number).ToString("F0");
                }
                // 売りポジが...
                else if (PositionTable.Rows[i].Cells["Position"].Value.ToString() == "売")
                {
                    // 狩られるか？
                    if (double.TryParse(PositionTable.Rows[i].Cells["OrderGyakuSashineValue"].Value.ToString(), out ordervalue))
                        if (ordervalue <= currentcandle[Const.IDXHI])
                        {
                            double yakujo = ordervalue < currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue;
                            RevOrder(i, yakujo, number, value - yakujo, currentcandle);
                            continue;
                        }
                    // 利確できるか？
                    if (double.TryParse(PositionTable.Rows[i].Cells["OrderSashineValue"].Value.ToString(), out ordervalue))
                        if (ordervalue >= currentcandle[Const.IDXLW])
                        {
                            double yakujo = ordervalue > currentcandle[Const.IDXOP] ? currentcandle[Const.IDXOP] : ordervalue;
                            RevOrder(i, yakujo, number, value - yakujo, currentcandle);
                            continue;
                        }

                    PositionTable.Rows[i].Cells["SonEki"].Value = ((value - currentcandle[Const.IDXCL]) * number).ToString("F0");
                }
            }
        }


        /// <summary>
        /// 練習モードを終了する
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // タイマー止める
            checkAutoInc.Checked = false;

            Visible = false; // 練習用コントロール非表示

            // 注文、建玉テーブルクリア
            for (int i = OrderTable.Rows.Count - 1; i >= 0; i--)
                OrderTable.Rows.RemoveAt(i);
            AddNewOrderTableRow();

            for (int i = PositionTable.Rows.Count - 1; i >= 0; i--)
                PositionTable.Rows.RemoveAt(i);

            // 注文ログを出力
            Directory.CreateDirectory(Path.GetDirectoryName(_orderlogfile));
            using (StreamWriter sw = new StreamWriter(_orderlogfile, false, Encoding.GetEncoding("shift_jis")))
            {
                // 新規|決済, 日時, 売|買, 数量, 約定価格, 損益
                foreach (Tuple<string, string, string, string, string, string> t in _orderlog)
                    sw.WriteLine(t.Item1 + "," + t.Item2 + "," + t.Item3 + "," + t.Item4 + "," + t.Item5 + "," + t.Item6);
            }

            _orderlog.Clear();

            SendPracticeModeFinish();
        }


        #region 注文設定


        /// <summary>
        /// 決済注文
        /// </summary>
        private void PositionTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            string sashine = PositionTable.Rows[e.RowIndex].Cells["OrderSashineValue"].Value.ToString();
            string gyakusashi = PositionTable.Rows[e.RowIndex].Cells["OrderGyakuSashineValue"].Value.ToString();
            RevOrderDialog order = new RevOrderDialog(sashine, gyakusashi);
            order.ShowDialog();

            switch (order.Order)
            {
                case Const.ONARI:
                    PositionTable.Rows[e.RowIndex].Cells["Value"].Value = GetCandle()[Const.IDXCL];
                    PositionTable.Rows[e.RowIndex].Cells["DateTime"].Value = FormatDate(GetCandle()[Const.IDXDATE]);
                    LogAdd("決済", e.RowIndex);
                    PositionTable.Rows.RemoveAt(e.RowIndex);
                    break;
                case Const.OSASHI:
                    PositionTable.Rows[e.RowIndex].Cells["OrderSashineValue"].Value = order.SashineValue;
                    PositionTable.Rows[e.RowIndex].Cells["OrderGyakuSashineValue"].Value = order.GyakuSashiValue;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// 新規注文
        /// </summary>
        private void OrderTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            // 注文が存在するセルをダブルクリックすると、その注文は削除される
            var value = OrderTable[0, e.RowIndex].Value;
            if (value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("この注文を削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    OrderTable.Rows.Remove(OrderTable.Rows[e.RowIndex]);
                }

                return;
            }

            NewOrderDialog order = new NewOrderDialog();
            order.currentvalue = GetCandle()[Const.IDXCL];
            order.ShowDialog();
            if (order.ret != DialogResult.OK) return;

            //成行注文は即座に建玉テーブルに反映される
            if (order.Order == Const.ONARI)
            {
                NewOrder(-1, order.Pos, order.Number, order.Value, GetCandle());
            }
            else
            {
                AddNewOrderTableRow();
                OrderTable[0, OrderTable.Rows.Count - 2].Value = order.Pos;
                OrderTable[1, OrderTable.Rows.Count - 2].Value = order.Number.ToString();
                OrderTable[2, OrderTable.Rows.Count - 2].Value = order.Value.ToString();
            }
        }

        #endregion


        private void NewOrder(int ordertablerow, string pos, double ordernum, double ordervalue, double[] currentcandle)
        {
            PositionTable.Rows.Add();
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["Position"].Value = pos;
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["Number"].Value = ordernum;
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["Value"].Value = ordervalue;
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["DateTime"].Value = FormatDate(currentcandle[Const.IDXDATE]);
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["OrderSashineValue"].Value = "";
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["OrderGyakuSashineValue"].Value = "";
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["SonEki"].Value = "";
            if (ordertablerow != -1)
                OrderTable.Rows.RemoveAt(ordertablerow);
            LogAdd("新規", PositionTable.Rows.Count - 1);
        }


        private void RevOrder(int positiontablerow, double yakujovalue, double number, double soneki, double[] currentcandle)
        {
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["Value"].Value = yakujovalue.ToString("F3");
            PositionTable.Rows[PositionTable.Rows.Count - 1].Cells["DateTime"].Value = FormatDate(currentcandle[Const.IDXDATE]);
            PositionTable.Rows[positiontablerow].Cells["SonEki"].Value = (soneki * number).ToString("F0");
            LogAdd("決済", positiontablerow);
            PositionTable.Rows.RemoveAt(positiontablerow);
        }


        private void LogAdd(string ordertype, int index)
        {
            string pos = PositionTable.Rows[index].Cells["Position"].Value.ToString();

            if(ordertype == "決済")
                pos = pos == "買" ? "売" : "買";

            _orderlog.Add(new Tuple<string, string, string, string, string, string>(
                ordertype,                                                      //新規 | 決済
                PositionTable.Rows[index].Cells["DateTime"].Value.ToString(),   // 日時
                pos,                                                            // 売 | 買
                PositionTable.Rows[index].Cells["Number"].Value.ToString(),     // 数量
                PositionTable.Rows[index].Cells["Value"].Value.ToString(),      // 約定価格
                ordertype == "新規" ? "" : PositionTable.Rows[index].Cells["SonEki"].Value.ToString()    // 損益
                ));
        }


        /// <summary>
        /// 注文テーブルを1行追加して初期化する。初期化しないとnullのままなので。
        /// </summary>
        private void AddNewOrderTableRow()
        {
            OrderTable.Rows.Add();
            OrderTable.Rows[OrderTable.Rows.Count - 1].Cells["Order"].Value = "";
            OrderTable.Rows[OrderTable.Rows.Count - 1].Cells["OrderNumber"].Value = "";
            OrderTable.Rows[OrderTable.Rows.Count - 1].Cells["OrderValue"].Value = "";
        }


        private string FormatDate(double date)
        {
            return ((int)(date / 10000000000)).ToString() + "/" +
                    ((int)(date / 100000000 % 100)).ToString() + "/" +
                    ((int)(date / 1000000 % 100)).ToString() + " " +
                    ((int)(date / 10000 % 100)).ToString() + ":" +
                    ((int)(date / 100 % 100)).ToString();
        }

        private void checkAutoInc_CheckedChanged(object sender, EventArgs e)
        {
            if(checkAutoInc.Checked)
            {
                timer1.Interval =  _intervalseconds;
                timer1.Tick += new EventHandler(IncButton_Click);
                timer1.Start();
            }
            else
            {
                timer1.Tick -= new EventHandler(IncButton_Click);
                timer1.Stop();
            }
        }
    }
}
