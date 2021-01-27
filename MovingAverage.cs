using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingFXChart
{
    static class MovingAverage
    {
        static public double[] MA(Currency currency, int param)
        {
            int tablelength = currency.Data.GetLength(0);
            if (tablelength < param)
                return null;

            // 平均値が入らない要素はNaNで埋めておく
            double[] ma = new double[tablelength];
            for (int i = 0; i < param - 1; i++)
                ma[i] = double.NaN;

            // MA作成
            double[] dtmp = new double[param];
            for (int i = param - 1; i < tablelength; i++)
            {
                for (int j = 0; j < param; j++)
                    dtmp[j] = currency.Data[i - j, Const.IDXCL];
                ma[i] = dtmp.Average();
            }

            return ma;
        }
    }
}
