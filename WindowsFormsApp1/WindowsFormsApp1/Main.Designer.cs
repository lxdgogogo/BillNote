
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
            this.编辑账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑账单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询周期账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本日账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本周账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本月账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年度账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询目前总收支ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账单记录ToolStripMenuItem,
            this.编辑账单ToolStripMenuItem,
            this.编辑账单ToolStripMenuItem1});
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
            // 编辑账单ToolStripMenuItem
            // 
            this.编辑账单ToolStripMenuItem.Name = "编辑账单ToolStripMenuItem";
            this.编辑账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.编辑账单ToolStripMenuItem.Text = "移除一个账单记录";
            // 
            // 编辑账单ToolStripMenuItem1
            // 
            this.编辑账单ToolStripMenuItem1.Name = "编辑账单ToolStripMenuItem1";
            this.编辑账单ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.编辑账单ToolStripMenuItem1.Text = "编辑账单";
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
            this.本日账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.本日账单ToolStripMenuItem.Text = "本日账单";
            // 
            // 本周账单ToolStripMenuItem
            // 
            this.本周账单ToolStripMenuItem.Name = "本周账单ToolStripMenuItem";
            this.本周账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.本周账单ToolStripMenuItem.Text = "本周账单";
            // 
            // 本月账单ToolStripMenuItem
            // 
            this.本月账单ToolStripMenuItem.Name = "本月账单ToolStripMenuItem";
            this.本月账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.本月账单ToolStripMenuItem.Text = "本月账单";
            // 
            // 年度账单ToolStripMenuItem
            // 
            this.年度账单ToolStripMenuItem.Name = "年度账单ToolStripMenuItem";
            this.年度账单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.年度账单ToolStripMenuItem.Text = "年度账单";
            // 
            // 查询目前总收支ToolStripMenuItem
            // 
            this.查询目前总收支ToolStripMenuItem.Name = "查询目前总收支ToolStripMenuItem";
            this.查询目前总收支ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询目前总收支ToolStripMenuItem.Text = "查询目前总收支";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "BillNote";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账单记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑账单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询周期账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本日账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本周账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本月账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年度账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询目前总收支ToolStripMenuItem;
    }
}