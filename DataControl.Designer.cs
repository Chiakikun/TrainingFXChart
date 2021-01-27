namespace TrainingFXChart
{
    partial class DataControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.NumericUpDown();
            this.ExecJump = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Minute);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Hour);
            this.groupBox1.Controls.Add(this.ExecJump);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Day);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Month);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Year);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日時でジャンプ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "分";
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(72, 43);
            this.Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(37, 19);
            this.Minute.TabIndex = 20;
            this.Minute.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "時";
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(6, 43);
            this.Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(37, 19);
            this.Hour.TabIndex = 18;
            this.Hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExecJump
            // 
            this.ExecJump.Location = new System.Drawing.Point(138, 40);
            this.ExecJump.Name = "ExecJump";
            this.ExecJump.Size = new System.Drawing.Size(75, 23);
            this.ExecJump.TabIndex = 17;
            this.ExecJump.Text = "ジャンプ";
            this.ExecJump.UseVisualStyleBackColor = true;
            this.ExecJump.Click += new System.EventHandler(this.ExecJump_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "日";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(153, 18);
            this.Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(37, 19);
            this.Day.TabIndex = 15;
            this.Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "月";
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(87, 18);
            this.Month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(37, 19);
            this.Month.TabIndex = 13;
            this.Month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "年";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(6, 18);
            this.Year.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(52, 19);
            this.Year.TabIndex = 11;
            this.Year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DataControl";
            this.Size = new System.Drawing.Size(243, 226);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Minute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Hour;
        private System.Windows.Forms.Button ExecJump;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Year;
    }
}
