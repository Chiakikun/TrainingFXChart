// マウスカーソル位置のローソク情報を表示する

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
    public partial class AttributeView : UserControl
    {
        private double[] _candle;
        private Font _font;
        private Brush _brush;


        public AttributeView()
        {
            InitializeComponent();
            _font = new Font("MS UI Gothic", 12);
            _brush = Brushes.Blue;
        }


        public void Setting(SettingDialog sd)
        {
            _font = sd.DataFont;
            _brush = sd.DataFontColor;
            Invalidate();
        }

        /// <summary>
        /// 表示させるローソクデータを取得する
        /// candle[0] = 年
        /// candle[1] = 月
        /// candle[2] = 日
        /// candle[3] = 時
        /// candle[4] = 分
        /// candle[5] = 始値
        /// candle[6] = 高値
        /// candle[7] = 安値
        /// candle[8] = 終値
        /// </summary>
        public void SetCandle(double[] candle)
        {
            _candle = candle;
            Invalidate();
        }


        private void AttributeView_Paint(object sender, PaintEventArgs e)
        {
            if (_candle == null) return;

            StringFormat sf = new StringFormat();
            
            string str = _candle[0].ToString() + "年" + _candle[1].ToString() + "月" + _candle[2].ToString() + "日 " + _candle[3].ToString() + ":" + _candle[4].ToString();
            e.Graphics.DrawString(str, _font, _brush, 0, 0);

            str = "始値:\t" + _candle[5].ToString();
            e.Graphics.DrawString(str, _font, _brush, 0, e.Graphics.MeasureString(str, _font, 1000, sf).Height * 2);

            str = "高値:\t" + _candle[6].ToString();
            e.Graphics.DrawString(str, _font, _brush, 0, e.Graphics.MeasureString(str, _font, 1000, sf).Height * 3);

            str = "安値:\t" + _candle[7].ToString();
            e.Graphics.DrawString(str, _font, _brush, 0, e.Graphics.MeasureString(str, _font, 1000, sf).Height * 4);

            str = "終値:\t" + _candle[8].ToString();
            e.Graphics.DrawString(str, _font, _brush, 0, e.Graphics.MeasureString(str, _font, 1000, sf).Height * 5);
        }
    }
}
