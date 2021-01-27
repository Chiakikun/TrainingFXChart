namespace TrainingFXChart
{
    partial class NewOrderDialog
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.NariyukiButton = new System.Windows.Forms.RadioButton();
            this.SashineButton = new System.Windows.Forms.RadioButton();
            this.LongOrderButton = new System.Windows.Forms.CheckBox();
            this.ShortOrderButton = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderValue = new System.Windows.Forms.TextBox();
            this.OrderNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(10, 90);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(106, 90);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NariyukiButton
            // 
            this.NariyukiButton.AutoSize = true;
            this.NariyukiButton.Location = new System.Drawing.Point(12, 40);
            this.NariyukiButton.Name = "NariyukiButton";
            this.NariyukiButton.Size = new System.Drawing.Size(71, 16);
            this.NariyukiButton.TabIndex = 3;
            this.NariyukiButton.TabStop = true;
            this.NariyukiButton.Text = "成行注文";
            this.NariyukiButton.UseVisualStyleBackColor = true;
            // 
            // SashineButton
            // 
            this.SashineButton.AutoSize = true;
            this.SashineButton.Location = new System.Drawing.Point(12, 62);
            this.SashineButton.Name = "SashineButton";
            this.SashineButton.Size = new System.Drawing.Size(71, 16);
            this.SashineButton.TabIndex = 4;
            this.SashineButton.TabStop = true;
            this.SashineButton.Text = "指値注文";
            this.SashineButton.UseVisualStyleBackColor = true;
            // 
            // LongOrderButton
            // 
            this.LongOrderButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.LongOrderButton.AutoSize = true;
            this.LongOrderButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LongOrderButton.Location = new System.Drawing.Point(7, 12);
            this.LongOrderButton.Name = "LongOrderButton";
            this.LongOrderButton.Size = new System.Drawing.Size(27, 22);
            this.LongOrderButton.TabIndex = 5;
            this.LongOrderButton.Text = "買";
            this.LongOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LongOrderButton.UseVisualStyleBackColor = true;
            this.LongOrderButton.CheckedChanged += new System.EventHandler(this.LongOrderButton_CheckedChanged);
            // 
            // ShortOrderButton
            // 
            this.ShortOrderButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShortOrderButton.AutoSize = true;
            this.ShortOrderButton.Location = new System.Drawing.Point(37, 12);
            this.ShortOrderButton.Name = "ShortOrderButton";
            this.ShortOrderButton.Size = new System.Drawing.Size(27, 22);
            this.ShortOrderButton.TabIndex = 6;
            this.ShortOrderButton.Text = "売";
            this.ShortOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShortOrderButton.UseVisualStyleBackColor = true;
            this.ShortOrderButton.CheckedChanged += new System.EventHandler(this.ShortOrderButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "現在値 ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // OrderValue
            // 
            this.OrderValue.Location = new System.Drawing.Point(89, 61);
            this.OrderValue.Name = "OrderValue";
            this.OrderValue.Size = new System.Drawing.Size(82, 19);
            this.OrderValue.TabIndex = 9;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DecimalPlaces = 1;
            this.OrderNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.OrderNumber.Location = new System.Drawing.Point(115, 14);
            this.OrderNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(53, 19);
            this.OrderNumber.TabIndex = 10;
            this.OrderNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "枚数";
            // 
            // OrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 120);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.OrderValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShortOrderButton);
            this.Controls.Add(this.LongOrderButton);
            this.Controls.Add(this.SashineButton);
            this.Controls.Add(this.NariyukiButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderDialog";
            this.Text = "新規注文";
            this.Shown += new System.EventHandler(this.OrderDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton NariyukiButton;
        private System.Windows.Forms.RadioButton SashineButton;
        private System.Windows.Forms.CheckBox LongOrderButton;
        private System.Windows.Forms.CheckBox ShortOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderValue;
        private System.Windows.Forms.NumericUpDown OrderNumber;
        private System.Windows.Forms.Label label3;
    }
}