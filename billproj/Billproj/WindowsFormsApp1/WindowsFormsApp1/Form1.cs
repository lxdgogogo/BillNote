using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string code = textBox2.Text;
            
            
        }
        public bool insertDB(String sql)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = sql;//设置SQL语句 
                    //cmd.Connection = conn();//调用打开数据库连接方法 
                    cmd.ExecuteNonQuery();//执行 
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
       // 单击“添加信息”按钮，将够造一条SQL语句（实现添加功能）。然后将这条语句传给insertDB方法，实现数据的添加。

    }
}
