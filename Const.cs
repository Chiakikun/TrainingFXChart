using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingFXChart
{
    public static class Const
    {
        public const uint IDXDATE = 0; // 日時
        public const uint IDXOP = 1; // 始値
        public const uint IDXHI = 2; // 高値
        public const uint IDXLW = 3; // 安値
        public const uint IDXCL = 4; // 終値
        public const uint ONEMINUTE = 100;
        public const uint FIVEMINUTE = 500;
        public const uint FIFTEENMINUTE = 1500;
        public const uint HALFHOUR = 3000;
        public const uint ONEHOUR = 6000;
        public const uint LCNT = 10;  // ライン描画可能数
        public const uint LCLR = 0;  // 線削除
        public const uint LHORZ = 1; // 水平線
        public const uint LMA = 2;   // 移動平均線
        public const uint ORDERCNT = 10; // 注文受付数
        public const uint POSCNT = 12;   // 建玉保有数
        public const uint OLONG = 1;
        public const uint OSHORT = 2;
        public const uint ONARI = 1;
        public const uint OSASHI = 2;
    }
}
