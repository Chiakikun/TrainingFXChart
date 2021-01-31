// 指定した日時に移動するためのコントロール
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
    public partial class DataControl : UserControl
    {
        public DataControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 検索した結果、得たインデックスを他のコントロールに設定する。失敗した場合は-1をセットする。
        /// </summary>
        public Action<int> SetIndex;

        /// <summary>
        /// 画面の一番右のローソクのインデックスを取得する。
        /// </summary>
        public Func<int> GetIndex;

        private Currency _currency;

        public Currency Currency
        {
            set
            {
                _currency = value;
            }
        }


        private void ExecJump_Click(object sender, EventArgs e)
        {
            double data = (double)(Year.Value * 10000000000 + Month.Value * 100000000 + Day.Value * 1000000 + Hour.Value * 10000 + Minute.Value * 100);

            for (int i = 0; i < _currency.Data.GetLength(0); i++)
            {
                if(_currency.Data[i, Const.IDXDATE] == data)
                {
                    SetIndex(i);
                    return;
                }
            }
            SetIndex(-1);
        }


        private void OffsetJump_Click(object sender, EventArgs e)
        {
            int idx = GetIndex() + (int)Offset.Value;

            if (idx > _currency.Data.GetLength(0))
                idx = _currency.Data.GetLength(0);

            SetIndex(idx);
        }
    }
}
