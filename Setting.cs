using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

//各ユーザー毎にアプリケーションの設定を保存するクラス。iniダメ「http://d.hatena.ne.jp/paz3/20091127/1259303402」
namespace TrainingFXChart
{
    class Setting : ApplicationSettingsBase
    {

        #region 練習

        [UserScopedSetting()]
        public int IntervalSeconds
        {
            get { return (int)this["IntervalSeconds"]; }
            set { this["IntervalSeconds"] = value; }
        }

        [UserScopedSetting()]
        public string OrderLogPath
        {
            get { return (string)this["OrderLogPath"]; }
            set { this["OrderLogPath"] = value; }
        }

        [UserScopedSetting()]
        public Color SonkiriColor
        {
            get { return (Color)this["SonkiriColor"]; }
            set { this["SonkiriColor"] = value; }
        }

        [UserScopedSetting()]
        public Color RikakuColor
        {
            get { return (Color)this["RikakuColor"]; }
            set { this["RikakuColor"] = value; }
        }

        [UserScopedSetting()]
        public Color PositionColor
        {
            get { return (Color)this["PositionColor"]; }
            set { this["PositionColor"] = value; }
        }

        [UserScopedSetting()]
        public Color OrderSellColor
        {
            get { return (Color)this["OrderSellColor"]; }
            set { this["OrderSellColor"] = value; }
        }

        [UserScopedSetting()]
        public Color OrderBuyColor
        {
            get { return (Color)this["OrderBuyColor"]; }
            set { this["OrderBuyColor"] = value; }
        }

        #endregion

        #region データ

        [UserScopedSetting()]
        public Color DataFontColor
        {
            get { return (Color)this["DataFontColor"]; }
            set { this["DataFontColor"] = value; }
        }

        [UserScopedSetting()]
        public float DataFontSize
        {
            get { return (float)this["DataFontSize"]; }
            set { this["DataFontSize"] = value; }
        }

        [UserScopedSetting()]
        public string DataFontName
        {
            get { return (string)this["DataFontName"]; }
            set { this["DataFontName"] = value; }
        }

        #endregion

        #region チャート
        [UserScopedSetting()]
        public Color CursorFontColor
        {
            get { return (Color)this["CursorFontColor"]; }
            set { this["CursorFontColor"] = value; }
        }

        [UserScopedSetting()]
        public float CursorFontSize
        {
            get { return (float)this["CursorFontSize"]; }
            set { this["CursorFontSize"] = value; }
        }

        [UserScopedSetting()]
        public string CursorFontName
        {
            get { return (string)this["CursorFontName"]; }
            set { this["CursorFontName"] = value; }
        }

        [UserScopedSetting()]
        public Color CanvasFontColor
        {
            get { return (Color)this["CanvasFontColor"]; }
            set { this["CanvasFontColor"] = value; }
        }

        [UserScopedSetting()]
        public float CanvasFontSize
        {
            get { return (float)this["CanvasFontSize"]; }
            set { this["CanvasFontSize"] = value; }
        }

        [UserScopedSetting()]
        public string CanvasFontName
        {
            get { return (string)this["CanvasFontName"]; }
            set { this["CanvasFontName"] = value; }
        }
        #endregion

        #region ローソク
        [UserScopedSetting()]
        public uint BodyWidth // ローソクの幅
        {
            get { return (uint)this["BodyWidth"]; }
            set { this["BodyWidth"] = value; }
        }

        [UserScopedSetting()]
        public Color YosenColor
        {
            get { return (Color)this["YosenColor"]; }
            set { this["YosenColor"] = value; }
        }

        [UserScopedSetting()]
        public Color InsenColor
        {
            get { return (Color)this["InsenColor"]; }
            set { this["InsenColor"] = value; }
        }

        #endregion

        [UserScopedSetting()]
        public FormWindowState WindowState
        {
            get { return (FormWindowState)this["WindowState"]; }
            set { this["WindowState"] = value; }
        }

        [UserScopedSetting()]
        public int SplitContaintainer1SplitterDistance
        {
            get { return (int)this["SplitContaintainer1SplitterDistance"]; }
            set { this["SplitContaintainer1SplitterDistance"] = value; }
        }

        [UserScopedSetting()]
        public int SplitContaintainer2SplitterDistance
        {
            get { return (int)this["SplitContaintainer2SplitterDistance"]; }
            set { this["SplitContaintainer2SplitterDistance"] = value; }
        }

        [UserScopedSetting()]
        public int SplitContaintainer3SplitterDistance
        {
            get { return (int)this["SplitContaintainer3SplitterDistance"]; }
            set { this["SplitContaintainer3SplitterDistance"] = value; }
        }
    }
}