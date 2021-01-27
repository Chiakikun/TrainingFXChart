// 線種の列でコンボボックスを使っていたが、いまいち挙動が理想的ではなかった。1回のクリックでリストが出てこない、リスト変更が直ちに検知されない等。
// 少々の手間でクリアできることは確認したが、頑張ってどうにかしなければならない機能ではないため、コンテキストメニューで対処することにした。
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingFXChart
{
    public partial class TechnicalLineManager : UserControl
    {
        private readonly int colKind = 0;
        private readonly int colValue = 1;
        private readonly int colColor = 2;

        // 線種選択メニューが表示される前に、選択行を覚えておくための変数。線種設定後にメニューが消えた後
        // どの行にデフォルト値を設定したらいいかわからなくなるので。
        private int menuRow;


        /// <summary>
        /// 他のコントロールから取得した移動平均線等の設定をセットする
        /// </summary>
        public Action<int, uint, double, Color> SetLineSetting; // 引数: 行番号(0スタート)、線種、設定値、色


        public TechnicalLineManager()
        {
            InitializeComponent();
            for (int i = 0; i < Const.LCNT; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[colKind,  i].Value = "";
                dataGridView1[colValue, i].Value = "";
                dataGridView1[colColor, i].Value = "";
            }
        }

        /// <summary>
        /// 他のコントロールから取得した移動平均線等の設定をセットする
        /// </summary>
        public void SetLineSettings(Tuple<int, uint, double, Color>[] settings)
        {
            // 一旦全部クリアしないで大丈夫？


            for (int i = 0; i < Const.LCNT; i++)
            {
                dataGridView1[colKind, settings[i].Item1].Value = ToString(settings[i].Item2);
                if (ToString(settings[i].Item2) == "")
                    dataGridView1[colValue, settings[i].Item1].Value = "";
                else
                    dataGridView1[colValue, settings[i].Item1].Value = settings[i].Item3;
                dataGridView1[colColor, settings[i].Item1].Style.BackColor = settings[i].Item4;
            }
        }


        #region 線設定

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            menuRow = -1;

            // 線種の列をダブルクリックすると、線種選択メニューが表示される
            if (e.ColumnIndex == colKind)
            {
                contextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.BelowRight);
                menuRow = e.RowIndex;
                return;
            }

            // 色の列をダブルクリックすると、カラーダイアログが表示されて、線の色を設定できる
            // 線種が未設定なら色設定できない
            var value = dataGridView1[colKind, e.RowIndex].Value;
            if (value.ToString() == "") return;
            if (e.ColumnIndex != colColor) return;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1[colColor, e.RowIndex].Style.BackColor = colorDialog1.Color;

                // 編集後に他コントロールに設定行の内容を送る
                SetLineSetting(e.RowIndex
                    , ToCode(dataGridView1[colKind, e.RowIndex].Value.ToString())
                    , double.Parse(dataGridView1[colValue, e.RowIndex].Value.ToString())
                    , colorDialog1.Color
                    );
            }
        }

        private string oldvalue; // 編集前の設定値の退避場所

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldvalue = dataGridView1[colValue, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double newvalue;
            if(!double.TryParse(dataGridView1[colValue, e.RowIndex].Value.ToString(), out newvalue))
            {
                MessageBox.Show("数値を入力してください");
                dataGridView1[colValue, e.RowIndex].Value = oldvalue;
                return;
            }

            // 編集後に他コントロールに設定行の内容を送る
            SetLineSetting(e.RowIndex
                , ToCode(dataGridView1[colKind, e.RowIndex].Value.ToString())
                , newvalue
                , dataGridView1[colColor, e.RowIndex].Style.BackColor
                );
        }

        #endregion


        #region メニュー選択で呼ばれるメソッド

        public Func<double[]> GetCandle; // 他コントロールから、現在表示中の一番右のローソクデータを取得する

        private void HorzLine_Click(object sender, EventArgs e)
        {
            double close = GetCandle()[Const.IDXCL]; // 水平線のデフォルト値は、現在表中の一番右のローソクの終値とした
            LineSetting("水平線", System.Drawing.Color.Red, close.ToString("F2"));
            dataGridView1[colValue, menuRow].ReadOnly = false;

            SetLineSetting(menuRow, Const.LHORZ, close, System.Drawing.Color.Red);
        }

        private void MALine_Click(object sender, EventArgs e)
        {
            LineSetting("移動平均線", System.Drawing.Color.Blue, "10"); // 10は私が使っているから
            dataGridView1[colValue, menuRow].ReadOnly = false;

            SetLineSetting(menuRow, Const.LMA, 10, System.Drawing.Color.Blue);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            LineSetting("", System.Drawing.Color.Empty, "");
            dataGridView1[colValue, menuRow].ReadOnly = true;

            SetLineSetting(menuRow, Const.LCLR, 0, System.Drawing.Color.Empty);
        }

        private void LineSetting(string linename, Color color, string defaultvalue)
        {
            bool change = false;

            var value = dataGridView1[colKind, menuRow].Value;
            if (value.ToString () != linename)
            {
                change = true;
            }

            if (change)
            {
                dataGridView1[colKind, menuRow].Value = linename;
                dataGridView1[colValue, menuRow].Value = defaultvalue;
                dataGridView1[colColor, menuRow].Style.BackColor = color;
            }
        }

        #endregion

        private uint ToCode(string linename)
        {
            switch(linename)
            {
                case "水平線": return Const.LHORZ;
                case "移動平均線": return Const.LMA;
                default: return Const.LCLR;
            }
        }

        private string ToString(uint code)
        {
            switch(code)
            {
                case Const.LHORZ: return "水平線";
                case Const.LMA: return "移動平均線";
                default: return "";
            }
        }
    }
}
