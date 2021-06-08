
namespace WindowsFormsApp1
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账单记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑账单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询周期账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本日账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本周账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本月账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年度账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询目前总收支ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.删除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.统计ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账单记录ToolStripMenuItem,
            this.编辑账单ToolStripMenuItem1,
            this.删除记录ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.新建ToolStripMenuItem.Text = "管理";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 账单记录ToolStripMenuItem
            // 
            this.账单记录ToolStripMenuItem.Name = "账单记录ToolStripMenuItem";
            this.账单记录ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.账单记录ToolStripMenuItem.Text = "新建一个账单记录";
            this.账单记录ToolStripMenuItem.Click += new System.EventHandler(this.账单记录ToolStripMenuItem_Click);
            // 
            // 编辑账单ToolStripMenuItem1
            // 
            this.编辑账单ToolStripMenuItem1.Name = "编辑账单ToolStripMenuItem1";
            this.编辑账单ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.编辑账单ToolStripMenuItem1.Text = "编辑账单";
            this.编辑账单ToolStripMenuItem1.Click += new System.EventHandler(this.编辑账单ToolStripMenuItem1_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询周期账单ToolStripMenuItem,
            this.查询目前总收支ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 查询周期账单ToolStripMenuItem
            // 
            this.查询周期账单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本日账单ToolStripMenuItem,
            this.本周账单ToolStripMenuItem,
            this.本月账单ToolStripMenuItem,
            this.年度账单ToolStripMenuItem});
            this.查询周期账单ToolStripMenuItem.Name = "查询周期账单ToolStripMenuItem";
            this.查询周期账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询周期账单ToolStripMenuItem.Text = "查询周期账单";
            // 
            // 本日账单ToolStripMenuItem
            // 
            this.本日账单ToolStripMenuItem.Name = "本日账单ToolStripMenuItem";
            this.本日账单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.本日账单ToolStripMenuItem.Text = "本日账单";
            this.本日账单ToolStripMenuItem.Click += new System.EventHandler(this.本日账单ToolStripMenuItem_Click);
            // 
            // 本周账单ToolStripMenuItem
            // 
            this.本周账单ToolStripMenuItem.Name = "本周账单ToolStripMenuItem";
            this.本周账单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.本周账单ToolStripMenuItem.Text = "本周账单";
            this.本周账单ToolStripMenuItem.Click += new System.EventHandler(this.本周账单ToolStripMenuItem_Click);
            // 
            // 本月账单ToolStripMenuItem
            // 
            this.本月账单ToolStripMenuItem.Name = "本月账单ToolStripMenuItem";
            this.本月账单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.本月账单ToolStripMenuItem.Text = "本月账单";
            this.本月账单ToolStripMenuItem.Click += new System.EventHandler(this.本月账单ToolStripMenuItem_Click);
            // 
            // 年度账单ToolStripMenuItem
            // 
            this.年度账单ToolStripMenuItem.Name = "年度账单ToolStripMenuItem";
            this.年度账单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.年度账单ToolStripMenuItem.Text = "年度账单";
            this.年度账单ToolStripMenuItem.Click += new System.EventHandler(this.年度账单ToolStripMenuItem_Click);
            // 
            // 查询目前总收支ToolStripMenuItem
            // 
            this.查询目前总收支ToolStripMenuItem.Name = "查询目前总收支ToolStripMenuItem";
            this.查询目前总收支ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询目前总收支ToolStripMenuItem.Text = "查询目前总收支";
            this.查询目前总收支ToolStripMenuItem.Click += new System.EventHandler(this.查询目前总收支ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillCode,
            this.Date,
            this.Money,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 358);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "编辑完成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillCode
            // 
            this.BillCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillCode.HeaderText = "账单编号";
            this.BillCode.MinimumWidth = 6;
            this.BillCode.Name = "BillCode";
            this.BillCode.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "日期";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Money.HeaderText = "收支";
            this.Money.MinimumWidth = 6;
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "种类";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "刷新账单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 删除记录ToolStripMenuItem
            // 
            this.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem";
            this.删除记录ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除记录ToolStripMenuItem.Text = "删除记录";
            this.删除记录ToolStripMenuItem.Click += new System.EventHandler(this.删除记录ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "BillNote";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账单记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑账单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询周期账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本日账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本周账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本月账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年度账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询目前总收支ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 删除记录ToolStripMenuItem;
    }
}