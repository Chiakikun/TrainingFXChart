namespace TrainingFXChart
{
    partial class PracticeModeControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IncButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PositionTable = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSashineValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderGyakuSashineValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonEki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkAutoInc = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // IncButton
            // 
            this.IncButton.Location = new System.Drawing.Point(35, 238);
            this.IncButton.Name = "IncButton";
            this.IncButton.Size = new System.Drawing.Size(75, 23);
            this.IncButton.TabIndex = 0;
            this.IncButton.Text = "進める";
            this.IncButton.UseVisualStyleBackColor = true;
            this.IncButton.Click += new System.EventHandler(this.IncButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(144, 238);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "終了";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 220);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PositionTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "建玉";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PositionTable
            // 
            this.PositionTable.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PositionTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Number,
            this.Value,
            this.DateTime,
            this.OrderSashineValue,
            this.OrderGyakuSashineValue,
            this.SonEki});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PositionTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.PositionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionTable.Location = new System.Drawing.Point(3, 3);
            this.PositionTable.Name = "PositionTable";
            this.PositionTable.RowHeadersVisible = false;
            this.PositionTable.RowTemplate.Height = 21;
            this.PositionTable.Size = new System.Drawing.Size(246, 188);
            this.PositionTable.TabIndex = 0;
            this.PositionTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PositionTable_CellMouseDoubleClick);
            // 
            // Position
            // 
            this.Position.FillWeight = 50F;
            this.Position.HeaderText = "売買";
            this.Position.MaxInputLength = 5;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 50;
            // 
            // Number
            // 
            this.Number.FillWeight = 50F;
            this.Number.HeaderText = "枚数";
            this.Number.MaxInputLength = 10;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // Value
            // 
            this.Value.FillWeight = 70F;
            this.Value.HeaderText = "価格";
            this.Value.MaxInputLength = 10;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 70;
            // 
            // DateTime
            // 
            this.DateTime.FillWeight = 80F;
            this.DateTime.HeaderText = "日時";
            this.DateTime.MaxInputLength = 20;
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 80;
            // 
            // OrderSashineValue
            // 
            this.OrderSashineValue.HeaderText = "決済値";
            this.OrderSashineValue.Name = "OrderSashineValue";
            this.OrderSashineValue.ReadOnly = true;
            this.OrderSashineValue.Width = 70;
            // 
            // OrderGyakuSashineValue
            // 
            this.OrderGyakuSashineValue.HeaderText = "損切値";
            this.OrderGyakuSashineValue.Name = "OrderGyakuSashineValue";
            this.OrderGyakuSashineValue.ReadOnly = true;
            this.OrderGyakuSashineValue.Width = 70;
            // 
            // SonEki
            // 
            this.SonEki.HeaderText = "損益";
            this.SonEki.Name = "SonEki";
            this.SonEki.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OrderTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "注文";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OrderTable
            // 
            this.OrderTable.AllowUserToAddRows = false;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.OrderNumber,
            this.OrderValue});
            this.OrderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTable.Location = new System.Drawing.Point(3, 3);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowHeadersVisible = false;
            this.OrderTable.RowTemplate.Height = 21;
            this.OrderTable.Size = new System.Drawing.Size(246, 188);
            this.OrderTable.TabIndex = 0;
            this.OrderTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderTable_CellMouseDoubleClick);
            // 
            // Order
            // 
            this.Order.HeaderText = "売買";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 60;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "数量";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Width = 70;
            // 
            // OrderValue
            // 
            this.OrderValue.HeaderText = "指値";
            this.OrderValue.Name = "OrderValue";
            this.OrderValue.ReadOnly = true;
            // 
            // checkAutoInc
            // 
            this.checkAutoInc.AutoSize = true;
            this.checkAutoInc.Location = new System.Drawing.Point(7, 221);
            this.checkAutoInc.Name = "checkAutoInc";
            this.checkAutoInc.Size = new System.Drawing.Size(48, 16);
            this.checkAutoInc.TabIndex = 4;
            this.checkAutoInc.Text = "自動";
            this.checkAutoInc.UseVisualStyleBackColor = true;
            this.checkAutoInc.CheckedChanged += new System.EventHandler(this.checkAutoInc_CheckedChanged);
            // 
            // PracticeModeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkAutoInc);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.IncButton);
            this.Name = "PracticeModeControl";
            this.Size = new System.Drawing.Size(263, 270);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PositionTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IncButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView PositionTable;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSashineValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderGyakuSashineValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonEki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkAutoInc;
    }
}
