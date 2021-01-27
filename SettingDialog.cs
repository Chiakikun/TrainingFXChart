using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingFXChart
{
    public partial class SettingDialog : Form
    {
        private DialogResult _ret;
        public DialogResult Ret{ get { return _ret; } }

        // ローソク
        public Brush YosenColor { get; set; }
        public Brush InsenColor { get; set; }
        public uint BodyWidth { get; set; }
        // チャート
        public Font CanvasFont { get; set; }
        public Brush CanvasFontColor { get; set; }
        public Font CursorFont { get; set; }
        public Brush CursorFontColor { get; set; }
        // データ
        public Font DataFont { get; set; }
        public Brush DataFontColor { get; set; }
        // 練習
        public Brush OrderBuyColor { get; set; }
        public Brush OrderSellColor { get; set; }
        public Brush PositionColor { get; set; }
        public Brush RikakuColor { get; set; }
        public Brush SonkiriColor { get; set; }
        public string OrderLogFile { get; set; }
        public int IntervalSeconds { get; set; }

        public SettingDialog()
        {
            InitializeComponent();
        }

        private void SettingDialog_Shown(object sender, EventArgs e)
        {
            // ローソク
            YosenColorView.BackColor = new Pen(YosenColor).Color;
            InsenColorView.BackColor = new Pen(InsenColor).Color;
            CandleWidthSelect.Value = BodyWidth;
            // チャート
            ChartFontView.Text = CanvasFont.Name + "/" + ((int)CanvasFont.Size).ToString() + "pt";
            FontColorView.BackColor = new Pen(CanvasFontColor).Color;
            CursorFontView.Text = CursorFont.Name + "/" + ((int)CursorFont.Size).ToString() + "pt";
            CursorFontColorView.BackColor = new Pen(CursorFontColor).Color;
            // データ
            DataFontView.Text = CursorFont.Name + "/" + ((int)CursorFont.Size).ToString() + "pt";
            DataFontColorView.BackColor = new Pen(DataFontColor).Color;
            // 練習
            OrderBuyColorView.BackColor = new Pen(OrderBuyColor).Color;
            OrderSellColorView.BackColor = new Pen(OrderSellColor).Color;
            PositionColorView.BackColor = new Pen(PositionColor).Color;
            RikakuColorView.BackColor = new Pen(RikakuColor).Color;
            SonkiriColorView.BackColor = new Pen(SonkiriColor).Color;
            OrderLog.Text = OrderLogFile;
            IntervalSecondsSelect.Value = IntervalSeconds;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // ローソク
            YosenColor = new SolidBrush(YosenColorView.BackColor);
            InsenColor = new SolidBrush(InsenColorView.BackColor);
            BodyWidth = (uint)CandleWidthSelect.Value;
            // チャート
            CanvasFont = fontDialog1.Font;
            CanvasFontColor = new SolidBrush(FontColorView.BackColor);
            CursorFont = fontDialog2.Font;
            CursorFontColor = new SolidBrush(CursorFontColorView.BackColor);
            // データ
            DataFont = fontDialog3.Font;
            DataFontColor = new SolidBrush(DataFontColorView.BackColor);
            // 練習
            OrderBuyColor = new SolidBrush(OrderBuyColorView.BackColor);
            OrderSellColor = new SolidBrush(OrderSellColorView.BackColor);
            PositionColor = new SolidBrush(PositionColorView.BackColor);
            RikakuColor = new SolidBrush(RikakuColorView.BackColor);
            SonkiriColor = new SolidBrush(SonkiriColorView.BackColor);
            OrderLogFile = OrderLog.Text;
            IntervalSeconds = (int)IntervalSecondsSelect.Value;

            _ret = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _ret = DialogResult.Cancel;
            Close();
        }

        #region ローソク

        private void YosenColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            YosenColorView.BackColor = colorDialog1.Color;
        }

        private void InsenColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            InsenColorView.BackColor = colorDialog1.Color;
        }

        #endregion


        #region チャート
        private void CursorFontColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            CursorFontColorView.BackColor = colorDialog1.Color;
        }

        private void CursorFontSelect_Click(object sender, EventArgs e)
        {
            if (fontDialog2.ShowDialog() != DialogResult.OK) return;

            string name = fontDialog2.Font.Name;
            int size = (int)fontDialog2.Font.Size;
            CursorFontView.Text = name + "/" + size.ToString() + "pt";
        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.OK) return;

            string name = fontDialog1.Font.Name;
            int size = (int)fontDialog1.Font.Size;
            ChartFontView.Text = name + "/" + size.ToString() + "pt";
        }

        private void FontColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            FontColorView.BackColor = colorDialog1.Color;
        }

        #endregion


        #region データ

        private void DataFontSelect_Click(object sender, EventArgs e)
        {
            if (fontDialog3.ShowDialog() != DialogResult.OK) return;

            string name = fontDialog3.Font.Name;
            int size = (int)fontDialog3.Font.Size;
            DataFontView.Text = name + "/" + size.ToString() + "pt";
        }

        private void DataFontColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            DataFontColorView.BackColor = colorDialog1.Color;
        }

        #endregion


        #region 練習

        private void OrderBuyColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            OrderBuyColorView.BackColor = colorDialog1.Color;
        }

        private void OrderSellColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            OrderSellColorView.BackColor = colorDialog1.Color;
        }

        private void PositionColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            PositionColorView.BackColor = colorDialog1.Color;
        }

        private void RikakuColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            RikakuColorView.BackColor = colorDialog1.Color;
        }

        private void SonkiriColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            SonkiriColorView.BackColor = colorDialog1.Color;
        }

        private void OrderLogSelect_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            OrderLog.Text = saveFileDialog1.FileName;
        }

        #endregion
    }
}
