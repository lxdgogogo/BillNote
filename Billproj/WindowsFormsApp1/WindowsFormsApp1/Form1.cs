using MySql.Data.MySqlClient;
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
        private MySqlConnection conn;
        public Form1()
        {
            string connectionString = "server = 121.196.102.135;port=3306;user=billnote;password=wHyaXdnjFZMkzewK;database=billnote;SslMode=None";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("已经建立连接");
            }

            catch (MySqlException e)	//catch捕获异常
            {
                Console.WriteLine(e.Message);
            }
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
            //SELECT * FROM `t_user` where username='tw' limit 1
            string str = "SELECT * FROM `register` where username='" + username + "'and password='" + code + "';";
            MySqlCommand co = new MySqlCommand(str, conn);  //查询数据库
            co = new MySqlCommand(str, conn);
            MySqlDataReader reader = co.ExecuteReader();
            bool flag = reader.Read();
            if (flag)
            {
                Main main = new Main();
                main.ShowDialog();
            }
            else
            {
                ;
            }
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register register = new Register(conn);
            register.ShowDialog();
        }
        // 单击“添加信息”按钮，将够造一条SQL语句（实现添加功能）。然后将这条语句传给insertDB方法，实现数据的添加。

    }
}
