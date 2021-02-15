namespace TrainingFXChart
{
    partial class SettingDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InsenColorSelect = new System.Windows.Forms.Button();
            this.YosenColorSelect = new System.Windows.Forms.Button();
            this.InsenColorView = new System.Windows.Forms.TextBox();
            this.YosenColorView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CandleWidthSelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CursorFontColorSelect = new System.Windows.Forms.Button();
            this.CursorFontColorView = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CursorFontSelect = new System.Windows.Forms.Button();
            this.CursorFontView = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FontColorSelect = new System.Windows.Forms.Button();
            this.FontColorView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChartFontSelect = new System.Windows.Forms.Button();
            this.ChartFontView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DataFontColorSelect = new System.Windows.Forms.Button();
            this.DataFontColorView = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataFontSelect = new System.Windows.Forms.Button();
            this.DataFontView = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.IntervalSecondsSelect = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.SonkiriColorSelect = new System.Windows.Forms.Button();
            this.SonkiriColorView = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RikakuColorSelect = new System.Windows.Forms.Button();
            this.PositionColorSelect = new System.Windows.Forms.Button();
            this.RikakuColorView = new System.Windows.Forms.TextBox();
            this.PositionColorView = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OrderSellColorSelect = new System.Windows.Forms.Button();
            this.OrderBuyColorSelect = new System.Windows.Forms.Button();
            this.OrderSellColorView = new System.Windows.Forms.TextBox();
            this.OrderBuyColorView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OrderLogSelect = new System.Windows.Forms.Button();
            this.OrderLog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.fontDialog3 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandleWidthSelect)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSecondsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.InsenColorSelect);
            this.tabPage1.Controls.Add(this.YosenColorSelect);
            this.tabPage1.Controls.Add(this.InsenColorView);
            this.tabPage1.Controls.Add(this.YosenColorView);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CandleWidthSelect);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ローソク";
            // 
            // InsenColorSelect
            // 
            this.InsenColorSelect.Location = new System.Drawing.Point(80, 71);
            this.InsenColorSelect.Name = "InsenColorSelect";
            this.InsenColorSelect.Size = new System.Drawing.Size(75, 23);
            this.InsenColorSelect.TabIndex = 8;
            this.InsenColorSelect.Text = "選択";
            this.InsenColorSelect.UseVisualStyleBackColor = true;
            this.InsenColorSelect.Click += new System.EventHandler(this.InsenColorSelectButton_Click);
            // 
            // YosenColorSelect
            // 
            this.YosenColorSelect.Location = new System.Drawing.Point(80, 38);
            this.YosenColorSelect.Name = "YosenColorSelect";
            this.YosenColorSelect.Size = new System.Drawing.Size(75, 23);
            this.YosenColorSelect.TabIndex = 7;
            this.YosenColorSelect.Text = "選択";
            this.YosenColorSelect.UseVisualStyleBackColor = true;
            this.YosenColorSelect.Click += new System.EventHandler(this.YosenColorSelectButton_Click);
            // 
            // InsenColorView
            // 
            this.InsenColorView.BackColor = System.Drawing.Color.White;
            this.InsenColorView.Location = new System.Drawing.Point(174, 73);
            this.InsenColorView.Name = "InsenColorView";
            this.InsenColorView.ReadOnly = true;
            this.InsenColorView.Size = new System.Drawing.Size(45, 19);
            this.InsenColorView.TabIndex = 5;
            // 
            // YosenColorView
            // 
            this.YosenColorView.BackColor = System.Drawing.Color.White;
            this.YosenColorView.Location = new System.Drawing.Point(174, 40);
            this.YosenColorView.Name = "YosenColorView";
            this.YosenColorView.ReadOnly = true;
            this.YosenColorView.Size = new System.Drawing.Size(45, 19);
            this.YosenColorView.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "陰線";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "陽線";
            // 
            // CandleWidthSelect
            // 
            this.CandleWidthSelect.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CandleWidthSelect.Location = new System.Drawing.Point(80, 9);
            this.CandleWidthSelect.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CandleWidthSelect.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CandleWidthSelect.Name = "CandleWidthSelect";
            this.CandleWidthSelect.Size = new System.Drawing.Size(62, 19);
            this.CandleWidthSelect.TabIndex = 1;
            this.CandleWidthSelect.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ローソクの幅";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.CursorFontColorSelect);
            this.tabPage2.Controls.Add(this.CursorFontColorView);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CursorFontSelect);
            this.tabPage2.Controls.Add(this.CursorFontView);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.FontColorSelect);
            this.tabPage2.Controls.Add(this.FontColorView);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ChartFontSelect);
            this.tabPage2.Controls.Add(this.ChartFontView);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "チャート";
            // 
            // CursorFontColorSelect
            // 
            this.CursorFontColorSelect.Location = new System.Drawing.Point(124, 96);
            this.CursorFontColorSelect.Name = "CursorFontColorSelect";
            this.CursorFontColorSelect.Size = new System.Drawing.Size(75, 23);
            this.CursorFontColorSelect.TabIndex = 17;
            this.CursorFontColorSelect.Text = "選択";
            this.CursorFontColorSelect.UseVisualStyleBackColor = true;
            this.CursorFontColorSelect.Click += new System.EventHandler(this.CursorFontColorSelect_Click);
            // 
            // CursorFontColorView
            // 
            this.CursorFontColorView.BackColor = System.Drawing.Color.White;
            this.CursorFontColorView.Location = new System.Drawing.Point(221, 98);
            this.CursorFontColorView.Name = "CursorFontColorView";
            this.CursorFontColorView.ReadOnly = true;
            this.CursorFontColorView.Size = new System.Drawing.Size(45, 19);
            this.CursorFontColorView.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "カーソルフォントカラー";
            // 
            // CursorFontSelect
            // 
            this.CursorFontSelect.Location = new System.Drawing.Point(124, 67);
            this.CursorFontSelect.Name = "CursorFontSelect";
            this.CursorFontSelect.Size = new System.Drawing.Size(75, 23);
            this.CursorFontSelect.TabIndex = 14;
            this.CursorFontSelect.Text = "選択";
            this.CursorFontSelect.UseVisualStyleBackColor = true;
            this.CursorFontSelect.Click += new System.EventHandler(this.CursorFontSelect_Click);
            // 
            // CursorFontView
            // 
            this.CursorFontView.AutoSize = true;
            this.CursorFontView.Location = new System.Drawing.Point(210, 74);
            this.CursorFontView.Name = "CursorFontView";
            this.CursorFontView.Size = new System.Drawing.Size(0, 12);
            this.CursorFontView.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "カーソルフォント";
            // 
            // FontColorSelect
            // 
            this.FontColorSelect.Location = new System.Drawing.Point(123, 35);
            this.FontColorSelect.Name = "FontColorSelect";
            this.FontColorSelect.Size = new System.Drawing.Size(75, 23);
            this.FontColorSelect.TabIndex = 11;
            this.FontColorSelect.Text = "選択";
            this.FontColorSelect.UseVisualStyleBackColor = true;
            this.FontColorSelect.Click += new System.EventHandler(this.FontColorSelect_Click);
            // 
            // FontColorView
            // 
            this.FontColorView.BackColor = System.Drawing.Color.White;
            this.FontColorView.Location = new System.Drawing.Point(220, 37);
            this.FontColorView.Name = "FontColorView";
            this.FontColorView.ReadOnly = true;
            this.FontColorView.Size = new System.Drawing.Size(45, 19);
            this.FontColorView.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "フォントカラー";
            // 
            // ChartFontSelect
            // 
            this.ChartFontSelect.Location = new System.Drawing.Point(123, 6);
            this.ChartFontSelect.Name = "ChartFontSelect";
            this.ChartFontSelect.Size = new System.Drawing.Size(75, 23);
            this.ChartFontSelect.TabIndex = 6;
            this.ChartFontSelect.Text = "選択";
            this.ChartFontSelect.UseVisualStyleBackColor = true;
            this.ChartFontSelect.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // ChartFontView
            // 
            this.ChartFontView.AutoSize = true;
            this.ChartFontView.Location = new System.Drawing.Point(209, 13);
            this.ChartFontView.Name = "ChartFontView";
            this.ChartFontView.Size = new System.Drawing.Size(0, 12);
            this.ChartFontView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "フォント";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.DataFontColorSelect);
            this.tabPage4.Controls.Add(this.DataFontColorView);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.DataFontSelect);
            this.tabPage4.Controls.Add(this.DataFontView);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(308, 244);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "データ";
            // 
            // DataFontColorSelect
            // 
            this.DataFontColorSelect.Location = new System.Drawing.Point(114, 36);
            this.DataFontColorSelect.Name = "DataFontColorSelect";
            this.DataFontColorSelect.Size = new System.Drawing.Size(75, 23);
            this.DataFontColorSelect.TabIndex = 17;
            this.DataFontColorSelect.Text = "選択";
            this.DataFontColorSelect.UseVisualStyleBackColor = true;
            this.DataFontColorSelect.Click += new System.EventHandler(this.DataFontColorSelect_Click);
            // 
            // DataFontColorView
            // 
            this.DataFontColorView.BackColor = System.Drawing.Color.White;
            this.DataFontColorView.Location = new System.Drawing.Point(211, 38);
            this.DataFontColorView.Name = "DataFontColorView";
            this.DataFontColorView.ReadOnly = true;
            this.DataFontColorView.Size = new System.Drawing.Size(45, 19);
            this.DataFontColorView.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "フォントカラー";
            // 
            // DataFontSelect
            // 
            this.DataFontSelect.Location = new System.Drawing.Point(114, 7);
            this.DataFontSelect.Name = "DataFontSelect";
            this.DataFontSelect.Size = new System.Drawing.Size(75, 23);
            this.DataFontSelect.TabIndex = 14;
            this.DataFontSelect.Text = "選択";
            this.DataFontSelect.UseVisualStyleBackColor = true;
            this.DataFontSelect.Click += new System.EventHandler(this.DataFontSelect_Click);
            // 
            // DataFontView
            // 
            this.DataFontView.AutoSize = true;
            this.DataFontView.Location = new System.Drawing.Point(200, 14);
            this.DataFontView.Name = "DataFontView";
            this.DataFontView.Size = new System.Drawing.Size(0, 12);
            this.DataFontView.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "フォント";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.IntervalSecondsSelect);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.SonkiriColorSelect);
            this.tabPage3.Controls.Add(this.SonkiriColorView);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.RikakuColorSelect);
            this.tabPage3.Controls.Add(this.PositionColorSelect);
            this.tabPage3.Controls.Add(this.RikakuColorView);
            this.tabPage3.Controls.Add(this.PositionColorView);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.OrderSellColorSelect);
            this.tabPage3.Controls.Add(this.OrderBuyColorSelect);
            this.tabPage3.Controls.Add(this.OrderSellColorView);
            this.tabPage3.Controls.Add(this.OrderBuyColorView);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.OrderLogSelect);
            this.tabPage3.Controls.Add(this.OrderLog);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(308, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "練習";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 26;
            this.label17.Text = "秒";
            // 
            // IntervalSecondsSelect
            // 
            this.IntervalSecondsSelect.Location = new System.Drawing.Point(90, 217);
            this.IntervalSecondsSelect.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.IntervalSecondsSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalSecondsSelect.Name = "IntervalSecondsSelect";
            this.IntervalSecondsSelect.Size = new System.Drawing.Size(62, 19);
            this.IntervalSecondsSelect.TabIndex = 25;
            this.IntervalSecondsSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "更新間隔";
            // 
            // SonkiriColorSelect
            // 
            this.SonkiriColorSelect.Location = new System.Drawing.Point(89, 184);
            this.SonkiriColorSelect.Name = "SonkiriColorSelect";
            this.SonkiriColorSelect.Size = new System.Drawing.Size(75, 23);
            this.SonkiriColorSelect.TabIndex = 23;
            this.SonkiriColorSelect.Text = "選択";
            this.SonkiriColorSelect.UseVisualStyleBackColor = true;
            this.SonkiriColorSelect.Click += new System.EventHandler(this.SonkiriColorSelect_Click);
            // 
            // SonkiriColorView
            // 
            this.SonkiriColorView.BackColor = System.Drawing.Color.White;
            this.SonkiriColorView.Location = new System.Drawing.Point(183, 186);
            this.SonkiriColorView.Name = "SonkiriColorView";
            this.SonkiriColorView.ReadOnly = true;
            this.SonkiriColorView.Size = new System.Drawing.Size(45, 19);
            this.SonkiriColorView.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "損切";
            // 
            // RikakuColorSelect
            // 
            this.RikakuColorSelect.Location = new System.Drawing.Point(89, 153);
            this.RikakuColorSelect.Name = "RikakuColorSelect";
            this.RikakuColorSelect.Size = new System.Drawing.Size(75, 23);
            this.RikakuColorSelect.TabIndex = 20;
            this.RikakuColorSelect.Text = "選択";
            this.RikakuColorSelect.UseVisualStyleBackColor = true;
            this.RikakuColorSelect.Click += new System.EventHandler(this.RikakuColorSelect_Click);
            // 
            // PositionColorSelect
            // 
            this.PositionColorSelect.Location = new System.Drawing.Point(89, 120);
            this.PositionColorSelect.Name = "PositionColorSelect";
            this.PositionColorSelect.Size = new System.Drawing.Size(75, 23);
            this.PositionColorSelect.TabIndex = 19;
            this.PositionColorSelect.Text = "選択";
            this.PositionColorSelect.UseVisualStyleBackColor = true;
            this.PositionColorSelect.Click += new System.EventHandler(this.PositionColorSelect_Click);
            // 
            // RikakuColorView
            // 
            this.RikakuColorView.BackColor = System.Drawing.Color.White;
            this.RikakuColorView.Location = new System.Drawing.Point(183, 155);
            this.RikakuColorView.Name = "RikakuColorView";
            this.RikakuColorView.ReadOnly = true;
            this.RikakuColorView.Size = new System.Drawing.Size(45, 19);
            this.RikakuColorView.TabIndex = 18;
            // 
            // PositionColorView
            // 
            this.PositionColorView.BackColor = System.Drawing.Color.White;
            this.PositionColorView.Location = new System.Drawing.Point(183, 122);
            this.PositionColorView.Name = "PositionColorView";
            this.PositionColorView.ReadOnly = true;
            this.PositionColorView.Size = new System.Drawing.Size(45, 19);
            this.PositionColorView.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "利確";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "建玉";
            // 
            // OrderSellColorSelect
            // 
            this.OrderSellColorSelect.Location = new System.Drawing.Point(89, 87);
            this.OrderSellColorSelect.Name = "OrderSellColorSelect";
            this.OrderSellColorSelect.Size = new System.Drawing.Size(75, 23);
            this.OrderSellColorSelect.TabIndex = 14;
            this.OrderSellColorSelect.Text = "選択";
            this.OrderSellColorSelect.UseVisualStyleBackColor = true;
            this.OrderSellColorSelect.Click += new System.EventHandler(this.OrderSellColorSelect_Click);
            // 
            // OrderBuyColorSelect
            // 
            this.OrderBuyColorSelect.Location = new System.Drawing.Point(89, 54);
            this.OrderBuyColorSelect.Name = "OrderBuyColorSelect";
            this.OrderBuyColorSelect.Size = new System.Drawing.Size(75, 23);
            this.OrderBuyColorSelect.TabIndex = 13;
            this.OrderBuyColorSelect.Text = "選択";
            this.OrderBuyColorSelect.UseVisualStyleBackColor = true;
            this.OrderBuyColorSelect.Click += new System.EventHandler(this.OrderBuyColorSelect_Click);
            // 
            // OrderSellColorView
            // 
            this.OrderSellColorView.BackColor = System.Drawing.Color.White;
            this.OrderSellColorView.Location = new System.Drawing.Point(183, 89);
            this.OrderSellColorView.Name = "OrderSellColorView";
            this.OrderSellColorView.ReadOnly = true;
            this.OrderSellColorView.Size = new System.Drawing.Size(45, 19);
            this.OrderSellColorView.TabIndex = 12;
            // 
            // OrderBuyColorView
            // 
            this.OrderBuyColorView.BackColor = System.Drawing.Color.White;
            this.OrderBuyColorView.Location = new System.Drawing.Point(183, 56);
            this.OrderBuyColorView.Name = "OrderBuyColorView";
            this.OrderBuyColorView.ReadOnly = true;
            this.OrderBuyColorView.Size = new System.Drawing.Size(45, 19);
            this.OrderBuyColorView.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "新規売";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "新規買";
            // 
            // OrderLogSelect
            // 
            this.OrderLogSelect.Location = new System.Drawing.Point(251, 24);
            this.OrderLogSelect.Name = "OrderLogSelect";
            this.OrderLogSelect.Size = new System.Drawing.Size(40, 23);
            this.OrderLogSelect.TabIndex = 2;
            this.OrderLogSelect.Text = "選択";
            this.OrderLogSelect.UseVisualStyleBackColor = true;
            this.OrderLogSelect.Click += new System.EventHandler(this.OrderLogSelect_Click);
            // 
            // OrderLog
            // 
            this.OrderLog.Location = new System.Drawing.Point(14, 26);
            this.OrderLog.Name = "OrderLog";
            this.OrderLog.Size = new System.Drawing.Size(231, 19);
            this.OrderLog.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "注文ログ";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(56, 278);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(189, 278);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 311);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingDialog";
            this.Text = "設定";
            this.Shown += new System.EventHandler(this.SettingDialog_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandleWidthSelect)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSecondsSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown CandleWidthSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChartFontSelect;
        private System.Windows.Forms.Label ChartFontView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsenColorSelect;
        private System.Windows.Forms.Button YosenColorSelect;
        private System.Windows.Forms.TextBox InsenColorView;
        private System.Windows.Forms.TextBox YosenColorView;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button FontColorSelect;
        private System.Windows.Forms.TextBox FontColorView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CursorFontColorSelect;
        private System.Windows.Forms.TextBox CursorFontColorView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CursorFontSelect;
        private System.Windows.Forms.Label CursorFontView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button DataFontColorSelect;
        private System.Windows.Forms.TextBox DataFontColorView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DataFontSelect;
        private System.Windows.Forms.Label DataFontView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FontDialog fontDialog3;
        private System.Windows.Forms.Button OrderLogSelect;
        private System.Windows.Forms.TextBox OrderLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OrderSellColorSelect;
        private System.Windows.Forms.Button OrderBuyColorSelect;
        private System.Windows.Forms.TextBox OrderSellColorView;
        private System.Windows.Forms.TextBox OrderBuyColorView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SonkiriColorSelect;
        private System.Windows.Forms.TextBox SonkiriColorView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button RikakuColorSelect;
        private System.Windows.Forms.Button PositionColorSelect;
        private System.Windows.Forms.TextBox RikakuColorView;
        private System.Windows.Forms.TextBox PositionColorView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown IntervalSecondsSelect;
        private System.Windows.Forms.Label label16;
    }
}