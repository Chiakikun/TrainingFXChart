namespace TrainingFXChart
{
    partial class RevOrderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SashineValueText = new System.Windows.Forms.TextBox();
            this.GyakuSashiValueText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderSashine = new System.Windows.Forms.RadioButton();
            this.OrderNariyuki = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(37, 108);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "注文確定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(132, 108);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "指値";
            // 
            // SashineValueText
            // 
            this.SashineValueText.Location = new System.Drawing.Point(59, 33);
            this.SashineValueText.Name = "SashineValueText";
            this.SashineValueText.Size = new System.Drawing.Size(100, 19);
            this.SashineValueText.TabIndex = 4;
            // 
            // GyakuSashiValueText
            // 
            this.GyakuSashiValueText.Location = new System.Drawing.Point(59, 58);
            this.GyakuSashiValueText.Name = "GyakuSashiValueText";
            this.GyakuSashiValueText.Size = new System.Drawing.Size(100, 19);
            this.GyakuSashiValueText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "逆指値";
            // 
            // OrderSashine
            // 
            this.OrderSashine.AutoSize = true;
            this.OrderSashine.Location = new System.Drawing.Point(12, 12);
            this.OrderSashine.Name = "OrderSashine";
            this.OrderSashine.Size = new System.Drawing.Size(71, 16);
            this.OrderSashine.TabIndex = 8;
            this.OrderSashine.TabStop = true;
            this.OrderSashine.Text = "指値注文";
            this.OrderSashine.UseVisualStyleBackColor = true;
            // 
            // OrderNariyuki
            // 
            this.OrderNariyuki.AutoSize = true;
            this.OrderNariyuki.Location = new System.Drawing.Point(12, 83);
            this.OrderNariyuki.Name = "OrderNariyuki";
            this.OrderNariyuki.Size = new System.Drawing.Size(71, 16);
            this.OrderNariyuki.TabIndex = 9;
            this.OrderNariyuki.TabStop = true;
            this.OrderNariyuki.Text = "成行注文";
            this.OrderNariyuki.UseVisualStyleBackColor = true;
            // 
            // RevOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 139);
            this.Controls.Add(this.OrderNariyuki);
            this.Controls.Add(this.OrderSashine);
            this.Controls.Add(this.GyakuSashiValueText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SashineValueText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RevOrderDialog";
            this.Text = "決済注文";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SashineValueText;
        private System.Windows.Forms.TextBox GyakuSashiValueText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OrderSashine;
        private System.Windows.Forms.RadioButton OrderNariyuki;
    }
}