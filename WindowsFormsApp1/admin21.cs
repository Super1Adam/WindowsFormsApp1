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
    public partial class admin21 : Form
    {
        public admin21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string a1, a2, a3, a4, a5, a6, a7,a8;
            a1 = textBox1.Text;
            a2 = textBox2.Text;
            a3 = textBox3.Text;
            a4 = textBox4.Text;
            a5 = textBox5.Text;
            a6 = textBox6.Text;
            a7 = textBox7.Text;
            a8 = textBox8.Text;
            string sql = $"insert into books values('{a1}','{a2}','{a3}','{a4}','{a5}','{a6}','{a7}','{a8}')";
            int n = dao.Excute(sql);
            if (n > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");

            }

        }
    }
}
