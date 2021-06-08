using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int flag = 0;
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

        private void label4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string code = textBox2.Text;
            if (username == "" || code=="")
            {
                MessageBox.Show("用户名或密码不得为空","警告");
            }
            string str = "SELECT * FROM `register` where username='" + username + "'and password='" + code + "';";
            MySqlCommand co = new MySqlCommand(str, conn);  //查询数据库
            co = new MySqlCommand(str, conn);
            MySqlDataReader reader = co.ExecuteReader();
            bool flag = reader.Read();
            if (flag)
            {
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
