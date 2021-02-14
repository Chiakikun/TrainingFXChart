using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingFXChart
{
    public partial class ChartCanvas : UserControl
    {
        private Currency _currency = null;

        private int idxCurrent;     // 表示している一番左のローソクのインデックス番号
        private int SpaceY = 100;   // キャンバスの上下の余白

        // ローソク
        private int iBodyWidth;     // 表示するローソクの幅
        private Pen BlackPen;       // 陰線
        private Pen WhitePen;       // 陽線

        // x軸、y軸に表示される価格、日時用
        private Font LabelFont;
        private Brush LabelBrush;

        // マウスカーソル位置に表示される破線、価格、日時用
        private Pen CursorPen;
        private Font CursorFont;
        private Brush CursorBrush;

        // 注文の水平線
        private Pen OrderBuyColor;
        private Pen OrderSellColor;
        // 建玉の水平線
        private Pen PositionColor;
        private Pen RikakuColor;
        private Pen SonkiriColor;

        private Point CursorPos;

        // 移動平均線や水平線
        private Tuple<uint, double, Color, double[]>[] TechnicalLines;  // 線種、設定値、色、データ


        /// <summary>
        /// 他コントロールに、現在マウスカーソルが指しているローソクのデータをセットする
        /// </summary>
        public Action<double[]> SetCandleData;


        /// <summary>
        /// 新規注文情報を他コントロールから取得する
        /// </summary>
        public Func<Tuple<string, double>[]> GetOrderData;


        /// <summary>
        /// 建玉情報を他コントロールから取得する
        /// </summary>
        public Func<Tuple<string, double, double, double>[]> GetPositionData;


        public ChartCanvas()
        {
            InitializeComponent();

            // 設定ダイアログでは変えないパラメータ
            CursorPen = new Pen(Brushes.White);
            CursorPen.DashPattern = new float[] { 5.0F, 5.0F };

            TechnicalLines = new Tuple<uint, double, Color, double[]>[Const.LCNT];
        }


        /// <summary>
        /// キャンバスに描画できるローソクの本数を返す
        /// </summary>
        private int DisplayColumn()
        {
            return (int)(this.Width / iBodyWidth);
        }


        /// <summary>
        /// データの行数
        /// </summary>
        private int CurrencyLength()
        {
            if (_currency == null) return 0;
            return _currency.Data.GetLength(0);
        }


        public void ScrollBarVisible(bool flg)
        {
            hScrollBar1.Visible = flg;
        }


        /// <summary>
        /// キャンバスに表示する通貨ペアを読み込む（1分足用）
        /// </summary>
        public void SetCurrency(Currency c)
        {
            _currency = c;

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = CurrencyLength() - 1;
            hScrollBar1.LargeChange = DisplayColumn();

            idxCurrent = CurrencyLength() - DisplayColumn();
            if (idxCurrent < 0)
                idxCurrent = 0;
            hScrollBar1.Value = idxCurrent;

            AdjustScrollBar();
            Invalidate();
        }


        /// <summary>
        /// キャンバスに表示する通貨ペアを読み込む（1分足以外用）
        /// </summary>
        public void SetCurrency(Currency c, int startidx, int endidx, uint div)
        {
            _currency = new Currency(c, div, startidx, endidx);

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = CurrencyLength() - 1;
            hScrollBar1.LargeChange = DisplayColumn();

            idxCurrent = CurrencyLength() - DisplayColumn();
            if (idxCurrent < 0)
                idxCurrent = 0;
            hScrollBar1.Value = idxCurrent;

            // ライン設定が存在するなら、読み込んだ通貨でラインを再作成する
            for (int i = 0; i < TechnicalLines.Length; i++)
            {
                if (TechnicalLines[i] == null) continue;

                if (TechnicalLines[i].Item1 == Const.LMA)
                {
                    double[] linevalues = MovingAverage.MA(_currency, (int)TechnicalLines[i].Item2);
                    TechnicalLines[i] = new Tuple<uint, double, Color, double[]>(TechnicalLines[i].Item1, TechnicalLines[i].Item2, TechnicalLines[i].Item3, linevalues);
                }
            }

            AdjustScrollBar();
            Invalidate();
        }


        /// <summary>
        /// キャンバスに表示する水平線やMAを設定する
        /// </summary>
        public void SetTechnicalLineSetting(Tuple<int, uint, double, Color> setting)
        {
            double[] linevalues = null;
            switch (setting.Item2)
            {
                case Const.LHORZ:
                    linevalues = new double[] { setting.Item3 };
                    break;
                case Const.LMA:
                    linevalues = MovingAverage.MA(_currency, (int)setting.Item3);
                    break;
                default: break;
            }
            TechnicalLines[setting.Item1] = new Tuple<uint, double, Color, double[]>(setting.Item2, setting.Item3, setting.Item4, linevalues);
            Invalidate();
        }


        /// <summary>
        /// キャンバスが表示している水平線やMAの設定情報を取得する
        /// </summary>
        public Tuple<int, uint, double, Color>[] GetTechnicalLines()
        {
            Tuple<int, uint, double, Color>[] ret = new Tuple<int, uint, double, Color>[Const.LCNT];
            for (int i = 0; i < TechnicalLines.Length; i++)
            {
                if (TechnicalLines[i] == null)
                    ret[i] = new Tuple<int, uint, double, Color>(i, Const.LCLR, 0, Color.Empty);
                else
                    ret[i] = new Tuple<int, uint, double, Color>(i, TechnicalLines[i].Item1, TechnicalLines[i].Item2, TechnicalLines[i].Item3);
            }
            return ret;
        }


        /// <summary>
        /// キャンバスに表示されている一番右のローソクのインデックス
        /// </summary>
        public int IdxEnd
        {
            get
            {
                int idxEndCandle = idxCurrent + DisplayColumn() - 1;
                if (idxEndCandle >= CurrencyLength())
                    idxEndCandle = CurrencyLength() - 1;
                return idxEndCandle;
            }
            set
            {
                idxCurrent = value - DisplayColumn() + 1;
                if (idxCurrent < 0)
                    idxCurrent = 0;
                AdjustScrollBar();
                Invalidate();
            }
        }


        /// <summary>
        /// キャンバスに表示されている一番右のローソクのデータ
        /// </summary>
        public double[] EndCandle
        {
            get
            {
                return new double[]
                {
                _currency.Data[IdxEnd, Const.IDXDATE],
                _currency.Data[IdxEnd, Const.IDXOP],
                _currency.Data[IdxEnd, Const.IDXHI],
                _currency.Data[IdxEnd, Const.IDXLW],
                _currency.Data[IdxEnd, Const.IDXCL]
                };
            }
        }


        private void DrawChart(Graphics g)
        {
            if (DesignMode) return;
            // キャンバスに表示するローソクの最初と最後
            int idxStartCandle = idxCurrent;
            int idxEndCandle = IdxEnd;

            // ローソクのy座標を決めるための係数
            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;
            for (int i = idxStartCandle; i <= idxEndCandle; i++)
            {
                min = Math.Min(min, _currency.Data[i, Const.IDXLW]);
                max = Math.Max(max, _currency.Data[i, Const.IDXHI]);
            }
            double coe = (this.Height - SpaceY * 2) / (max - min); // 係数

            // テクニカル指標用
            List<Point>[] drawtecline = new List<Point>[TechnicalLines.Length];
            for (int i = 0; i < TechnicalLines.Length; i++)
                drawtecline[i] = new List<Point>();

            int iCount = 0;
            while (idxStartCandle <= idxEndCandle)
            {
                int x = iCount * iBodyWidth + iBodyWidth / 2;
                int y = (this.Height - SpaceY);

                // キャンバスにローソクを描画する
                DrawCandle(g, x, y, 
                    (int)((_currency.Data[idxStartCandle, Const.IDXOP] - min) * coe),
                    (int)((_currency.Data[idxStartCandle, Const.IDXHI] - min) * coe),
                    (int)((_currency.Data[idxStartCandle, Const.IDXLW] - min) * coe),
                    (int)((_currency.Data[idxStartCandle, Const.IDXCL] - min) * coe));

                // x軸に日時を表示する
                DrawXAxisValue(g, x, idxStartCandle);

                // 移動平均線を設定する
                for (int i = 0; i < TechnicalLines.Length; i++)
                {
                    if (TechnicalLines[i] == null) continue;
                    if (TechnicalLines[i].Item4 == null) continue;
                    if (TechnicalLines[i].Item1 != Const.LMA) continue;
                    if (double.IsNaN(TechnicalLines[i].Item4[idxStartCandle])) continue;
                    drawtecline[i].Add(new Point(x, y - (int)((TechnicalLines[i].Item4[idxStartCandle] - min) * coe)));
                }

                iCount++;
                idxStartCandle++;
            }

            // 水平線、移動平均線等を描画する
            for (int i = 0; i < TechnicalLines.Length; i++)
            {
                if (TechnicalLines[i] == null) continue;
                if (TechnicalLines[i].Item4 == null) continue;
                if (TechnicalLines[i].Item1 == Const.LMA) // MA
                    g.DrawLines(new Pen(TechnicalLines[i].Item3), drawtecline[i].ToArray());
                else if (TechnicalLines[i].Item1 == Const.LHORZ) // 水平線
                    DrawHorzLine(g, new Pen(TechnicalLines[i].Item3), (int)((TechnicalLines[i].Item4[0] - min) * coe));
            }

            // y軸に価格を表示する
            DrawYAxisValue(g, (int)(max * 100), (int)(min * 100), coe);

            // マウスカーソル
            DrawMouseCorsor(g, min, coe);

            // 注文の水平線
            Tuple<string, double>[] order = GetOrderData();
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i].Item1 == "買")
                    DrawHorzLine(g, OrderBuyColor, (int)((order[i].Item2 - min) * coe));
                else
                    DrawHorzLine(g, OrderSellColor, (int)((order[i].Item2 - min) * coe));
            }

            // 建玉の水平線
            Tuple<string, double, double, double>[] position = GetPositionData();
            for(int i = 0; i < position.Length; i++)
            {
                DrawHorzLine(g, PositionColor, (int)((position[i].Item2 - min) * coe));
                DrawHorzLine(g, RikakuColor,   (int)((position[i].Item3 - min) * coe));
                DrawHorzLine(g, SonkiriColor,  (int)((position[i].Item4 - min) * coe));
            }
        }


        private void AdjustScrollBar()
        {
            if (_currency == null)
            {
                hScrollBar1.Enabled = false;
            }
            else
            {
                int total = CurrencyLength();
                int display = DisplayColumn();
                if (display >= total)
                {
                    hScrollBar1.Enabled = false;
                }
                else
                {
                    // データ数を超えてウィンドウが広げられた場合
                    if (CurrencyLength() <= display + idxCurrent)
                        idxCurrent = CurrencyLength() - display;

                    hScrollBar1.LargeChange = display;
                    hScrollBar1.Value = idxCurrent;
                    hScrollBar1.Enabled = true;
                }
            }
        }


        private float GetPosXAxisString(Graphics g, string value, Font f)
        {
            StringFormat sf = new StringFormat();
            return Width - g.MeasureString(value, f, 1000, sf).Width;
        }


        private float GetPosYAxisString(Graphics g, string value, Font f)
        {
            StringFormat sf = new StringFormat();
            return Height - hScrollBar1.Height - g.MeasureString(value, f, 1000, sf).Height;
        }


        public void Setting(SettingDialog sd)
        {
            WhitePen = new Pen(sd.YosenColor);
            BlackPen = new Pen(sd.InsenColor);
            iBodyWidth = (int)sd.BodyWidth;

            LabelFont = sd.CanvasFont;
            LabelBrush = sd.CanvasFontColor;

            CursorFont = sd.CursorFont;
            CursorBrush = sd.CursorFontColor;

            OrderBuyColor = new Pen(sd.OrderBuyColor);
            OrderBuyColor.DashStyle = DashStyle.Dash;
            OrderBuyColor.DashPattern = new float[] { 5, 5 };
            OrderSellColor = new Pen(sd.OrderSellColor);
            OrderSellColor.DashStyle = DashStyle.Dash;
            OrderSellColor.DashPattern = new float[] { 5, 5 };

            PositionColor = new Pen(sd.PositionColor);
            RikakuColor = new Pen(sd.RikakuColor);
            SonkiriColor = new Pen(sd.SonkiriColor);

            AdjustScrollBar();
            Invalidate();
        }

        #region イベント

        /// <summary>
        /// マウスを動かす度に、その位置のローソクの情報を送る
        /// </summary>
        private void ChartCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            int idx = (int)(e.X / iBodyWidth) + idxCurrent;
            if (idx < CurrencyLength())
            {
                SetCandleData(new double[] {
                _currency.GetYear(idx),
                _currency.GetMonth(idx),
                _currency.GetDay(idx),
                _currency.GetHour(idx),
                _currency.GetMinute(idx),
                _currency.Data[idx, Const.IDXOP],
                _currency.Data[idx, Const.IDXHI],
                _currency.Data[idx, Const.IDXLW],
                _currency.Data[idx, Const.IDXCL]});
            }
            CursorPos = e.Location;
            Invalidate();
        }

        private void ChartCanvas_MouseLeave(object sender, EventArgs e)
        {
            CursorPos.X = -1; // キャンバス外ならカーソル描画しないようにするため
            Invalidate();
        }
        private void ChartCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawChart(e.Graphics);
        }

        private void ChartCanvas_Resize(object sender, EventArgs e)
        {
            if (_currency == null) return;

            int i = IdxEnd;
            AdjustScrollBar();
            Invalidate();
            int d = IdxEnd;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            idxCurrent = hScrollBar1.Value;
            Invalidate();
        }

        #endregion

        #region Draw関係

        private void DrawCandle(Graphics g, int x, int y, int op, int hi, int lw, int cl)
        {
            int candle_org_x = x - iBodyWidth / 2;

            if (op > cl)
            {
                g.DrawLine(BlackPen, x, y - hi, x, y - lw);
                g.FillRectangle(BlackPen.Brush, candle_org_x, y - op, iBodyWidth, Math.Abs(op - cl));
            }
            else if (op < cl)
            {
                g.DrawLine(WhitePen, x, y - hi, x, y - lw);
                g.FillRectangle(WhitePen.Brush, candle_org_x, y - cl, iBodyWidth, Math.Abs(op - cl));
            }
            else
            {
                g.DrawLine(BlackPen, x, y - hi, x, y - lw);
                g.DrawLine(BlackPen, candle_org_x, y - cl, candle_org_x + iBodyWidth, y - cl);
            }
        }

        /// <summary>
        /// 水平線を描画する
        /// </summary>
        private void DrawHorzLine(Graphics g, Pen pen, int horzvalue)
        {
            int x1 = 0;
            int x2 = this.Width;
            int y = (this.Height - SpaceY) - horzvalue;

            g.DrawLines(pen, new Point[] { new Point(x1, y), new Point(x2, y) });

        }

        /// <summary>
        /// X軸に日時を描画する
        /// </summary>
        private void DrawXAxisValue(Graphics g, int posx, int idxcandle)
        {
            string hourstr = _currency.GetHour(idxcandle).ToString().PadLeft(2, '0');
            string minstr = _currency.GetMinute(idxcandle).ToString().PadLeft(2, '0');
            string datestr = hourstr + ":" + minstr;

            switch (_currency.Div)
            {
                case Const.ONEMINUTE:
                    if (minstr == "00")
                        g.DrawString(datestr, LabelFont, LabelBrush, new PointF(posx, GetPosYAxisString(g, datestr, LabelFont)));
                    break;
                case Const.FIVEMINUTE:
                    if (((hourstr[1] == '0') || (hourstr[1] == '2') || (hourstr[1] == '4') || (hourstr[1] == '6') || (hourstr[1] == '8')) && (minstr == "00"))
                        g.DrawString(datestr, LabelFont, LabelBrush, new PointF(posx, GetPosYAxisString(g, datestr, LabelFont)));
                    break;
                case Const.FIFTEENMINUTE:
                    if (((hourstr == "00") || (hourstr == "12")) && (minstr == "00"))
                        g.DrawString(datestr, LabelFont, LabelBrush, new PointF(posx, GetPosYAxisString(g, datestr, LabelFont)));
                    break;
                case Const.ONEHOUR:
                    string daystr = _currency.GetDay(idxcandle).ToString().PadLeft(2, '0');
                    datestr = _currency.GetMonth(idxcandle).ToString().PadLeft(2, '0') + "/" + daystr;
                    if ((_currency.GetYoubi(idxcandle) == "土") && (hourstr == "00") && (minstr == "00"))
                        g.DrawString(datestr, LabelFont, LabelBrush, new PointF(posx, GetPosYAxisString(g, datestr, LabelFont)));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Y軸に価格を切り良く描画する
        /// </summary>
        private void DrawYAxisValue(Graphics g, int max, int min, double coe)
        {
            // いくつの桁から変わっているかな？
            double log = Math.Floor(Math.Log10(max - min));
            double pow = Math.Pow(10, log);
            double d = (int)Math.Floor((max - min) / pow) * pow;

            int num = 6; // 1画面に表示させるy軸数の目安
            int span;
            if (d / 2 < num)
                span = 2;
            else if (d / 5 < num)
                span = 5;
            else if (d / 10 < num)
                span = 10;
            else if (d / 20 < num)
                span = 20;
            else if (d / 50 < num)
                span = 50;
            else if (d / 100 < num)
                span = 100;
            else if (d / 500 < num)
                span = 500;
            else
                span = 1000;

            int ibase = 0;
            for (int dtmp = min; dtmp < max; dtmp++)
            {
                if (dtmp % span != 0) continue;
                ibase = dtmp;
                break;
            }

            for (int i = ibase; i < max; i += span)
            {
                int y = Height - SpaceY - (int)((i - min) / 100.0 * coe);
                string value = (i / 100.0).ToString("F3");
                g.DrawString(value, LabelFont, LabelBrush, new PointF(GetPosXAxisString(g, value, LabelFont), y));
            }
            return;
        }

        private void DrawMouseCorsor(Graphics g, double min, double coe)
        {
            if (CursorPos.X == -1) return;
            // カーソル位置の十字線
            g.DrawLine(CursorPen, CursorPos.X, 0, CursorPos.X, this.Height);
            g.DrawLine(CursorPen, 0, CursorPos.Y, this.Width, CursorPos.Y);
            // x軸に表示する価格
            string value = ((Height - SpaceY - CursorPos.Y) / coe + min).ToString("F3");
            g.DrawString(value, CursorFont, CursorBrush, new PointF(GetPosXAxisString(g, value, CursorFont), CursorPos.Y));
        }
        #endregion
    }

}
