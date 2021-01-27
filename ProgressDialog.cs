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
    public partial class ProgressDialog : Form
    {

        public ProgressDialog()
        {
            InitializeComponent();
        }


        public DialogResult Ret
        {
            get; set;
        }


        public string Title
        {
            set
            {
                this.Text = value;
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Ret = DialogResult.Cancel;
        }


        private void ProgressDialog_Shown(object sender, EventArgs e)
        {
            Ret = DialogResult.None;
        }


        public void SetProgressMaxValue(int i)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() => { progressBar1.Maximum = i; }));
            else
                progressBar1.Maximum = i;
        }


        public void SetValue(int i)
        {
            try
            {
                if (InvokeRequired)
                    this.Invoke(new Action(() => { progressBar1.Value = i; }));
                else
                    progressBar1.Value = i;
            }
            catch // Invoke中にフォームが閉じられた場合（ｘボタン押されたとき等）
            {
                // ダサいのは承知しています。https://teratail.com/questions/74870
            }
        }


        public void FormClose()
        {
            if (InvokeRequired)
                this.Invoke(new Action(() => { this.Close(); }));
            else
                this.Close();
        }


        private void ProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Ret != DialogResult.OK) // 作業が完了する前に×ボタンで閉じられた場合
                Ret = DialogResult.Cancel;
        }
    }
}
