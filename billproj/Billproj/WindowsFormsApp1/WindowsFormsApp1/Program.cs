using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string connectionString = "server = 121.196.102.135;port=3306;user=billnote;password=wHyaXdnjFZMkzewK;database=billnote;SslMode=None";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("已经建立连接");
                string str = "INSERT INTO register values ('lxd','1');";    //sql语句，添加记录
                MySqlCommand co = new MySqlCommand(str, conn);  //往表内添加记录
                co = new MySqlCommand(str, conn);			//往表内添加记录（同上）
                co.ExecuteNonQuery();   //执行sql添加语句      
            }

            catch (MySqlException e)	//catch捕获异常
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                conn.Close();	//关闭连接
            }

        }
    }
}
