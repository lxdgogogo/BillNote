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
    public partial class Register : Form
    {
        private MySqlConnection conn;
        public Register()
        {
            InitializeComponent();
        }
        public Register(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string code = textBox2.Text;
            if (username == "" || code == "")
            {
                MessageBox.Show("注册用户名或密码不得为空", "警告");
            }
            else
            {
                //string str = "INSERT INTO register values ('lxd','1');";
                string str = "INSERT INTO register values ('" + username + "','" + code + "');";
                MySqlCommand co = new MySqlCommand(str, conn);  //往表内添加记录
                co = new MySqlCommand(str, conn);			//往表内添加记录（同上）
                co.ExecuteNonQuery();   //执行sql添加语句  
                Close();
            }
        }
    }
}
