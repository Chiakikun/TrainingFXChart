// 建玉テーブルをダブルクリックしたら表示される決済注文用ダイアログ
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
    public partial class RevOrderDialog : Form
    {
        private uint _os;

        public RevOrderDialog(string sashine, string gyakusashi)
        {
            InitializeComponent();

            SashineValueText.Text = sashine;
            GyakuSashiValueText.Text = gyakusashi;
            _os = 0;
        }


        /// <summary>
        /// 注文タイプ
        /// 0 変更無し
        /// Const.ONARI = 成行
        /// Const.OSASHI = 指値 
        /// </summary>
        public uint Order
        {
            get
            {
                return _os;
            }
        }


        public string SashineValue
        {
            get
            {
                return SashineValueText.Text;
            }
        }


        public string GyakuSashiValue
        {
            get
            {
                return GyakuSashiValueText.Text;
            }
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            _os = 0;

            if(OrderNariyuki.Checked)
            {
                _os = Const.ONARI;
                Close();
            }
            else if(OrderSashine.Checked)
            {
                double dtmp = 0;
                if((SashineValueText.Text != "") && !double.TryParse(SashineValueText.Text, out dtmp))
                {
                    MessageBox.Show("指値には数値を入力してください");
                    return;
                }
                if ((GyakuSashiValueText.Text != "") && !double.TryParse(GyakuSashiValueText.Text, out dtmp))
                {
                    MessageBox.Show("逆指値には数値を入力してください");
                    return;
                }
                _os = Const.OSASHI;
                Close();
            }
            else
            {
                MessageBox.Show("注文方法を選択してください");
            }

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
