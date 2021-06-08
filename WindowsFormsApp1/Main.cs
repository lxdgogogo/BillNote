using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Call_calc(string type)
        {
            /*
             * type: label1 type
             * income: label 3
             * cost: label 5
             * total: label 7
             */
            Calculate calc = new Calculate(type);
            calc.ShowDialog();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 账单记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadBill uploadBill = new UploadBill();
            uploadBill.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /* 下列为合计统计函数 */
        private void 本日账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 显示本日的账务 支出与收入
             */
            Call_calc("本日");
        }

        private void 本周账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 显示本周的账务 支出与收入
             */
            Call_calc("本周");
        }

        private void 本月账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 显示本月的账务 支出与收入
             */
            Call_calc("本月");
        }

        private void 年度账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Call_calc("年度");
        }

        private void 查询目前总收支ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Call_calc("总收支");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 编辑账单ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            button1.Visible = false;
        }
    }
}
