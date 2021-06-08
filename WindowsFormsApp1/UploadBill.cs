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
    public partial class UploadBill : Form
    {
        public UploadBill()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text; // I/O cost type
            string io = comboBox2.Text; // Income/Expenditure
            string year = comboBox3.Text;
            string month = comboBox4.Text;
            string date = comboBox5.Text;
            string flow = textBox1.Text;
            bool flag = true;
            if (type == "") flag = false;
            if (io == "") flag = false;
            if (year == "") flag = false;
            if (month == "") flag = false;
            if (date == "") flag = false;
            if (flow == "") flag = false;
            int money = 0 ,year_int=0;

            for(int i = 0; i < flow.Length; ++i)
            {
                if (flow[i] < '0' || flow[i] > '9')
                {
                    flag = false;
                    break;
                }
                money = money * 10 + flow[i] - '0';
            }
            for(int i = 0; i < year.Length; ++i)
            {
                year_int = year_int * 10 + year[i] - '0';
            }
            //检查收支是否是数字组成的
            if (date == "31")
            {
                if (month == "2") flag = false;
                if (month == "4") flag = false;
                if (month == "6") flag = false;
                if (month == "9") flag = false;
                if (month == "11") flag = false;
            }
            if (month == "2")
            {
                if (date == "30") flag = false;
                if (year_int % 4 != 0 && date == "29") flag = false;
            }
            if (flag)
            {
                //正常进入并且上传数据
                if (io == "支出")
                {
                    money = -1*money;
                }
                this.Close();
            }
            else
            {
                //返回重输并提示警告
                MessageBox.Show("输入有误！", "警告");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
