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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to_delete = textBox1.Text;
            bool is_valid = true;
            for(int i = 0; i < to_delete.Length; ++i)
            {
                if(to_delete[i]<'0' || to_delete[i] > '9')
                {
                    is_valid = false;
                    break;
                }
            }
            /*
             * 还需补写是否查询到这一条 
             * */
            if (is_valid)
            {
                //TODO 将这个记录删除

                this.Close();
            }

        }
    }
}
