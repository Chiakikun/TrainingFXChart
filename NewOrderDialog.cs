// 注文テーブルをダブルクリックしたら呼ばれる、新規注文を設定するためのダイアログ

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
    public partial class NewOrderDialog : Form
    {
        private uint _order;
        private double _value;

        public DialogResult ret;


        public NewOrderDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 注文タイプ
        /// 成行注文 = Const.ONARI
        /// 指値注文 = Const.OSASHI
        /// </summary>
        public uint Order
        {
            get
            {
                return _order;
            }
        }

        /// <summary>
        /// 売買種別
        /// 売り注文 = "売"
        /// 買い注文 = "買"
        /// </summary>
        public string Pos
        {
            get
            {
                if (ShortOrderButton.Checked)
                    return "売";
                else if (LongOrderButton.Checked)
                    return "買";
                else // 無いと思うが一応
                    throw new Exception("売買が選択されていません");
            }
        }

        /// <summary>
        /// 注文価格
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
        }


        /// <summary>
        /// 注文数量
        /// </summary>
        public double Number
        {
            get
            {
                return (double)OrderNumber.Value;
            }
        }


        private void OrderDialog_Shown(object sender, EventArgs e)
        {
            ret = DialogResult.Cancel;
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            if(!LongOrderButton.Checked && !ShortOrderButton.Checked)
            {
                MessageBox.Show("売買を指定してください。");
                return;
            }

            if(!SashineButton.Checked && !NariyukiButton.Checked)
            {
                MessageBox.Show("注文方法を指定してください。");
                return;
            }

            if (SashineButton.Checked) // 指値注文
            {
                _order = Const.OSASHI;
                double dtmp = 0;
                if(!double.TryParse(OrderValue.Text, out dtmp))
                {
                    MessageBox.Show("指値には数値を指定してください。");
                    return;
                }
                _value = dtmp;
            }
            else // 成行注文
            {
                _order = Const.ONARI;
            }

            ret = DialogResult.OK;
            Close();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ShortOrderButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LongOrderButton.Checked)
                LongOrderButton.Checked = false;
        }

        private void LongOrderButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ShortOrderButton.Checked)
                ShortOrderButton.Checked = false;
        }
    }
}
