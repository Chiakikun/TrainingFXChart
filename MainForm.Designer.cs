namespace TrainingFXChart
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.練習ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.chartCanvas1 = new TrainingFXChart.ChartCanvas();
            this.tab5Minute = new System.Windows.Forms.TabPage();
            this.chartCanvas2 = new TrainingFXChart.ChartCanvas();
            this.tab15Minute = new System.Windows.Forms.TabPage();
            this.chartCanvas3 = new TrainingFXChart.ChartCanvas();
            this.tab1Hour = new System.Windows.Forms.TabPage();
            this.chartCanvas4 = new TrainingFXChart.ChartCanvas();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.attributeView1 = new TrainingFXChart.AttributeView();
            this.technicalLineManager1 = new TrainingFXChart.TechnicalLineManager();
            this.practiceModeControl1 = new TrainingFXChart.PracticeModeControl();
            this.dataControl1 = new TrainingFXChart.DataControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tab5Minute.SuspendLayout();
            this.tab15Minute.SuspendLayout();
            this.tab1Hour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.練習ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 練習ToolStripMenuItem
            // 
            this.練習ToolStripMenuItem.Name = "練習ToolStripMenuItem";
            this.練習ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.練習ToolStripMenuItem.Text = "練習";
            this.練習ToolStripMenuItem.Click += new System.EventHandler(this.練習ToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(766, 385);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBase);
            this.tabControl1.Controls.Add(this.tab5Minute);
            this.tabControl1.Controls.Add(this.tab15Minute);
            this.tabControl1.Controls.Add(this.tab1Hour);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 385);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.chartCanvas1);
            this.tabBase.Location = new System.Drawing.Point(4, 22);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(470, 359);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "1分足";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // chartCanvas1
            // 
            this.chartCanvas1.BackColor = System.Drawing.Color.DimGray;
            this.chartCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCanvas1.Location = new System.Drawing.Point(3, 3);
            this.chartCanvas1.Name = "chartCanvas1";
            this.chartCanvas1.Size = new System.Drawing.Size(464, 353);
            this.chartCanvas1.TabIndex = 1;
            // 
            // tab5Minute
            // 
            this.tab5Minute.Controls.Add(this.chartCanvas2);
            this.tab5Minute.Location = new System.Drawing.Point(4, 22);
            this.tab5Minute.Name = "tab5Minute";
            this.tab5Minute.Padding = new System.Windows.Forms.Padding(3);
            this.tab5Minute.Size = new System.Drawing.Size(470, 359);
            this.tab5Minute.TabIndex = 1;
            this.tab5Minute.Text = "5分足";
            this.tab5Minute.UseVisualStyleBackColor = true;
            // 
            // chartCanvas2
            // 
            this.chartCanvas2.BackColor = System.Drawing.Color.DimGray;
            this.chartCanvas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCanvas2.Location = new System.Drawing.Point(3, 3);
            this.chartCanvas2.Name = "chartCanvas2";
            this.chartCanvas2.Size = new System.Drawing.Size(464, 353);
            this.chartCanvas2.TabIndex = 0;
            // 
            // tab15Minute
            // 
            this.tab15Minute.Controls.Add(this.chartCanvas3);
            this.tab15Minute.Location = new System.Drawing.Point(4, 22);
            this.tab15Minute.Name = "tab15Minute";
            this.tab15Minute.Padding = new System.Windows.Forms.Padding(3);
            this.tab15Minute.Size = new System.Drawing.Size(470, 359);
            this.tab15Minute.TabIndex = 2;
            this.tab15Minute.Text = "15分足";
            this.tab15Minute.UseVisualStyleBackColor = true;
            // 
            // chartCanvas3
            // 
            this.chartCanvas3.BackColor = System.Drawing.Color.DimGray;
            this.chartCanvas3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCanvas3.Location = new System.Drawing.Point(3, 3);
            this.chartCanvas3.Name = "chartCanvas3";
            this.chartCanvas3.Size = new System.Drawing.Size(464, 353);
            this.chartCanvas3.TabIndex = 0;
            // 
            // tab1Hour
            // 
            this.tab1Hour.Controls.Add(this.chartCanvas4);
            this.tab1Hour.Location = new System.Drawing.Point(4, 22);
            this.tab1Hour.Name = "tab1Hour";
            this.tab1Hour.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Hour.Size = new System.Drawing.Size(470, 359);
            this.tab1Hour.TabIndex = 3;
            this.tab1Hour.Text = "1時間足";
            this.tab1Hour.UseVisualStyleBackColor = true;
            // 
            // chartCanvas4
            // 
            this.chartCanvas4.BackColor = System.Drawing.Color.DimGray;
            this.chartCanvas4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCanvas4.Location = new System.Drawing.Point(3, 3);
            this.chartCanvas4.Name = "chartCanvas4";
            this.chartCanvas4.Size = new System.Drawing.Size(464, 353);
            this.chartCanvas4.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.practiceModeControl1);
            this.splitContainer2.Panel2.Controls.Add(this.dataControl1);
            this.splitContainer2.Size = new System.Drawing.Size(284, 385);
            this.splitContainer2.SplitterDistance = 187;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.attributeView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.technicalLineManager1);
            this.splitContainer3.Size = new System.Drawing.Size(284, 187);
            this.splitContainer3.SplitterDistance = 94;
            this.splitContainer3.TabIndex = 0;
            // 
            // attributeView1
            // 
            this.attributeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.attributeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeView1.Location = new System.Drawing.Point(0, 0);
            this.attributeView1.Name = "attributeView1";
            this.attributeView1.Size = new System.Drawing.Size(284, 94);
            this.attributeView1.TabIndex = 0;
            // 
            // technicalLineManager1
            // 
            this.technicalLineManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.technicalLineManager1.Location = new System.Drawing.Point(0, 0);
            this.technicalLineManager1.Name = "technicalLineManager1";
            this.technicalLineManager1.Size = new System.Drawing.Size(284, 89);
            this.technicalLineManager1.TabIndex = 0;
            // 
            // practiceModeControl1
            // 
            this.practiceModeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.practiceModeControl1.IdxCurrent = 0;
            this.practiceModeControl1.Location = new System.Drawing.Point(0, 0);
            this.practiceModeControl1.Name = "practiceModeControl1";
            this.practiceModeControl1.Size = new System.Drawing.Size(284, 194);
            this.practiceModeControl1.TabIndex = 1;
            this.practiceModeControl1.Visible = false;
            // 
            // dataControl1
            // 
            this.dataControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataControl1.Location = new System.Drawing.Point(0, 0);
            this.dataControl1.Name = "dataControl1";
            this.dataControl1.Size = new System.Drawing.Size(284, 194);
            this.dataControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 409);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TrainingFXChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tab5Minute.ResumeLayout(false);
            this.tab15Minute.ResumeLayout(false);
            this.tab1Hour.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DataControl dataControl1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBase;
        private ChartCanvas chartCanvas1;
        private System.Windows.Forms.TabPage tab5Minute;
        private System.Windows.Forms.TabPage tab15Minute;
        private System.Windows.Forms.TabPage tab1Hour;
        private ChartCanvas chartCanvas2;
        private ChartCanvas chartCanvas3;
        private ChartCanvas chartCanvas4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AttributeView attributeView1;
        private TechnicalLineManager technicalLineManager1;
        private System.Windows.Forms.ToolStripMenuItem 練習ToolStripMenuItem;
        private PracticeModeControl practiceModeControl1;
    }
}

