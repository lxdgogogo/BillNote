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
    public partial class Calculate : Form
    {
        public Calculate(string type)
        {
            InitializeComponent();
            label1.Text = type+"账单";
            /*
                label3.Text = income;
                label5.Text = cost;
                label7.Text = income-cost;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
