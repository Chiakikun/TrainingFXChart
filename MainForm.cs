using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainingFXChart
{
    public partial class MainForm : Form
    {
        private Currency BaseCurrency = null;
        private bool PracticeMode;
        private ChartCanvas CurrentCanvas; // 現在表示しているキャンバス

        public MainForm()
        {
            InitializeComponent();

            // ChartCanvas
            this.chartCanvas1.SetCandleData += this.SetCandleData;
            this.chartCanvas2.SetCandleData += this.SetCandleData;
            this.chartCanvas3.SetCandleData += this.SetCandleData;
            this.chartCanvas4.SetCandleData += this.SetCandleData;
            this.chartCanvas1.GetOrderData += this.GetOrder;
            this.chartCanvas2.GetOrderData += this.GetOrder;
            this.chartCanvas3.GetOrderData += this.GetOrder;
            this.chartCanvas4.GetOrderData += this.GetOrder;
            this.chartCanvas1.GetPositionData += this.GetPosition;
            this.chartCanvas2.GetPositionData += this.GetPosition;
            this.chartCanvas3.GetPositionData += this.GetPosition;
            this.chartCanvas4.GetPositionData += this.GetPosition;

            // DataControl
            this.dataControl1.SetIndex += this.SetCandleIndex;
            this.dataControl1.GetIndex += this.GetIndex;

            // TechnicalLineManager
            this.technicalLineManager1.SetLineSetting += this.SetLineSetting;
            this.technicalLineManager1.GetCandle += this.GetCandle;

            // PracticeModeControl
            this.practiceModeControl1.SendPracticeModeFinish += this.PracticeModeFinish;
            this.practiceModeControl1.SetCurrentIndex += this.SetCandleIndex;
            this.practiceModeControl1.GetCandle += this.GetCandle;

            LoadSetting();

            PracticeMode = false;
            練習ToolStripMenuItem.Enabled = false;
            tabControl1.Visible = false;
            splitContainer1.Visible = false;
            splitContainer2.Visible = false;
            splitContainer3.Visible = false;
        }


        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSVファイル|*.csv";
            if (open.ShowDialog() != DialogResult.OK) return;

            try
            {
                // ファイル読み込み
                try
                {
                    BaseCurrency = new Currency(open.FileName);
                }
                catch (Exception ce)
                {
                    MessageBox.Show(ce.Message);
                    return;
                }

                chartCanvas1.SetCurrency(BaseCurrency);
                CurrentCanvas = chartCanvas1;
                dataControl1.Currency = BaseCurrency;
                練習ToolStripMenuItem.Enabled = true;
                tabControl1.Visible = true;
                splitContainer1.Visible = true;
                splitContainer2.Visible = true;
                splitContainer3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }


        private void 練習ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PracticeMode)
            {
                練習ToolStripMenuItem.Enabled = false;
                practiceModeControl1.IdxCurrent = chartCanvas1.IdxEnd;
                practiceModeControl1.Visible = true;
                TernPracticeMode(true);
            }
            else
            {
                TernPracticeMode(false);
            }
        }
        private void TernPracticeMode(bool flg)
        {
            PracticeMode = flg;
            chartCanvas1.ScrollBarVisible(!flg);
            chartCanvas2.ScrollBarVisible(!flg);
            chartCanvas3.ScrollBarVisible(!flg);
            chartCanvas4.ScrollBarVisible(!flg);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int index = chartCanvas1.IdxEnd;

            switch (e.TabPageIndex)
            {
                case 0: // 1分足 ベース
                    technicalLineManager1.SetLineSettings(chartCanvas1.GetTechnicalLines());
                    chartCanvas1.IdxEnd = index;
                    CurrentCanvas = chartCanvas1;
                    break;
                case 1:
                    chartCanvas2.SetCurrency(BaseCurrency, 0, index + 1, Const.FIVEMINUTE);
                    technicalLineManager1.SetLineSettings(chartCanvas2.GetTechnicalLines());
                    CurrentCanvas = chartCanvas2;
                    break;
                case 2:
                    chartCanvas3.SetCurrency(BaseCurrency, 0, index + 1, Const.FIFTEENMINUTE);
                    technicalLineManager1.SetLineSettings(chartCanvas3.GetTechnicalLines());
                    CurrentCanvas = chartCanvas3;
                    break;
                case 3:
                    chartCanvas4.SetCurrency(BaseCurrency, 0, index + 1, Const.ONEHOUR);
                    technicalLineManager1.SetLineSettings(chartCanvas4.GetTechnicalLines());
                    CurrentCanvas = chartCanvas4;
                    break;
                default:
                    break;
            }
        }


        private void PracticeModeFinish()
        {
            TernPracticeMode(false);
            練習ToolStripMenuItem.Enabled = true;
        }

        #region 設定関係

        private Setting _setting;
        private SettingDialog _settingdialog;

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settingdialog.ShowDialog();

            if (_settingdialog.Ret != DialogResult.OK) return;

            ControlsSetting();
        }

        private void LoadSetting()
        {
            _setting = new Setting();
            try
            {
                this.splitContainer1.SplitterDistance = _setting.SplitContaintainer1SplitterDistance;
                this.splitContainer2.SplitterDistance = _setting.SplitContaintainer2SplitterDistance;
                this.splitContainer3.SplitterDistance = _setting.SplitContaintainer3SplitterDistance;
                this.WindowState = _setting.WindowState;
            }
            catch
            {
            }

            _settingdialog = new SettingDialog();
            // ローソク
            try { _settingdialog.YosenColor = new Pen(_setting.YosenColor).Brush; } catch { _settingdialog.YosenColor = Brushes.White; }
            try { _settingdialog.InsenColor = new Pen(_setting.InsenColor).Brush; } catch { _settingdialog.InsenColor = Brushes.Black; }
            try { _settingdialog.BodyWidth = _setting.BodyWidth; } catch { _settingdialog.BodyWidth = 5; }
            // チャート
            try { _settingdialog.CanvasFont = new Font(_setting.CanvasFontName, _setting.CanvasFontSize); } catch { _settingdialog.CanvasFont = new Font("MS UI Gothic", 8); }
            try { _settingdialog.CanvasFontColor = new Pen(_setting.CanvasFontColor).Brush; } catch { _settingdialog.CanvasFontColor = Brushes.DarkGray; }
            try { _settingdialog.CursorFont = new Font(_setting.CursorFontName, _setting.CursorFontSize); } catch { _settingdialog.CursorFont = new Font("MS UI Gothic", 8); }
            try { _settingdialog.CursorFontColor = new Pen(_setting.CursorFontColor).Brush; } catch { _settingdialog.CursorFontColor = Brushes.DarkGray; }
            // データ
            try { _settingdialog.DataFont = new Font(_setting.DataFontName, _setting.DataFontSize); } catch { _settingdialog.DataFont = new Font("MS UI Gothic", 16); }
            try { _settingdialog.DataFontColor = new Pen(_setting.DataFontColor).Brush; } catch { _settingdialog.DataFontColor = Brushes.DarkGray; }
            // 練習
            try { _settingdialog.OrderLogFile = _setting.OrderLogPath == null ? throw new Exception(""): _setting.OrderLogPath; } catch { _settingdialog.OrderLogFile = Path.GetDirectoryName(Application.ExecutablePath) + "\\log.txt"; }
            try { _settingdialog.OrderBuyColor = new Pen(_setting.OrderBuyColor).Brush; } catch { _settingdialog.OrderBuyColor = Brushes.Red; }
            try { _settingdialog.OrderSellColor = new Pen(_setting.OrderSellColor).Brush; } catch { _settingdialog.OrderSellColor = Brushes.Blue; }
            try { _settingdialog.PositionColor = new Pen(_setting.PositionColor).Brush; } catch { _settingdialog.PositionColor = Brushes.Gray; }
            try { _settingdialog.RikakuColor = new Pen(_setting.RikakuColor).Brush; } catch { _settingdialog.RikakuColor = Brushes.Green; }
            try { _settingdialog.SonkiriColor = new Pen(_setting.SonkiriColor).Brush; } catch { _settingdialog.SonkiriColor = Brushes.Purple; }
            try { _settingdialog.IntervalSeconds = _setting.IntervalSeconds; } catch { _settingdialog.IntervalSeconds = 10; }

            ControlsSetting();
        }

        private void SaveSetting()
        {
            // ローソク
            _setting.YosenColor = new Pen(_settingdialog.YosenColor).Color;
            _setting.InsenColor = new Pen(_settingdialog.InsenColor).Color;
            _setting.BodyWidth = _settingdialog.BodyWidth;
            // チャート
            _setting.CanvasFontName = _settingdialog.CanvasFont.Name;
            _setting.CanvasFontSize = _settingdialog.CanvasFont.Size;
            _setting.CanvasFontColor = new Pen(_settingdialog.CanvasFontColor).Color;
            _setting.CursorFontName = _settingdialog.CursorFont.Name;
            _setting.CursorFontSize = _settingdialog.CursorFont.Size;
            _setting.CursorFontColor = new Pen(_settingdialog.CursorFontColor).Color;
            // データ
            _setting.DataFontName = _settingdialog.DataFont.Name;
            _setting.DataFontSize = _settingdialog.DataFont.Size;
            _setting.DataFontColor = new Pen(_settingdialog.DataFontColor).Color;
            // 練習
            _setting.OrderLogPath =_settingdialog.OrderLogFile;
            _setting.OrderBuyColor = new Pen(_settingdialog.OrderBuyColor).Color;
            _setting.OrderSellColor = new Pen(_settingdialog.OrderSellColor).Color;
            _setting.RikakuColor = new Pen(_settingdialog.RikakuColor).Color;
            _setting.SonkiriColor = new Pen(_settingdialog.SonkiriColor).Color;
            _setting.PositionColor = new Pen(_settingdialog.PositionColor).Color;
            _setting.IntervalSeconds = _settingdialog.IntervalSeconds;

            _setting.WindowState = this.WindowState;
            this.WindowState = FormWindowState.Normal; // 一度ノーマルにしないとsplitの状態が正しく保存されない

            _setting.SplitContaintainer1SplitterDistance = this.splitContainer1.SplitterDistance;
            _setting.SplitContaintainer2SplitterDistance = this.splitContainer2.SplitterDistance;
            _setting.SplitContaintainer3SplitterDistance = this.splitContainer3.SplitterDistance;

            _setting.Save();
        }

        /// <summary>
        /// 各コントロールに設定を渡す
        /// </summary>
        private void ControlsSetting()
        {
            chartCanvas1.Setting(_settingdialog);
            chartCanvas2.Setting(_settingdialog);
            chartCanvas3.Setting(_settingdialog);
            chartCanvas4.Setting(_settingdialog);
            attributeView1.Setting(_settingdialog);
            practiceModeControl1.Setting(_settingdialog);
        }

        #endregion

        #region  他のコントロールから情報を受け取るメソッド

        /// <summary>
        /// ChartCanvasの一番右に表示させたいローソクのインデックス番号をセットする
        /// </summary>
        private void SetCandleIndex(int index)
        {
            if (index == -1)
            {
                MessageBox.Show("指定された日時では検索できませんでした");
                return;
            }

            // 0からindexまでの1分足データで、現在選択している足を再作成する
            chartCanvas1.IdxEnd = index;
            tabControl1_Selected(this, new TabControlEventArgs(tabControl1.TabPages[tabControl1.SelectedIndex], tabControl1.SelectedIndex, TabControlAction.Selected));
        }


        /// <summary>
        /// ChartCanvas上のマウス位置にあるローソクのデータをAttributeViewにセットする
        /// </summary>
        private void SetCandleData(double[] candle)
        {
            attributeView1.SetCandle(candle);
        }


        /// <summary>
        /// TechnicalLineManagerの移動平均線等の設定をChartCanvasにセットする
        /// </summary>
        private void SetLineSetting(int row, uint kind, double param, Color color)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // 1分足 ベース
                    chartCanvas1.SetTechnicalLineSetting(new Tuple<int, uint, double, Color>(row, kind, param, color));
                    break;
                case 1:
                    chartCanvas2.SetTechnicalLineSetting(new Tuple<int, uint, double, Color>(row, kind, param, color));
                    break;
                case 2:
                    chartCanvas3.SetTechnicalLineSetting(new Tuple<int, uint, double, Color>(row, kind, param, color));
                    break;
                case 3:
                    chartCanvas4.SetTechnicalLineSetting(new Tuple<int, uint, double, Color>(row, kind, param, color));
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// PracticeModeControlから建玉情報を取得してChartCanvasに渡す
        /// </summary>
        private Tuple<string, double, double, double>[] GetPosition()
        {
            return practiceModeControl1.GetPosition();
        }


        /// <summary>
        /// PracticeModeControlから注文情報を取得してChartCanvasに渡す
        /// </summary>
        private Tuple<string, double>[] GetOrder()
        {
            return practiceModeControl1.GetOrder();
        }


        /// <summary>
        /// ChartCanvasが表示している一番右のローソクのデータを取得する
        /// </summary>
        private double[] GetCandle()
        {
            return chartCanvas1.EndCandle;
        }


        /// <summary>
        /// ChartCanvasが表示している一番右のローソクのインデックスを取得する
        /// </summary>
        private int GetIndex()
        {
            return chartCanvas1.IdxEnd;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
