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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User1 user = new User1();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("输入有空请重新输入");
            }
        }
        public Boolean login()//登陆方法是否允许验证，允许返回真
        {
            if(radioButton1.Checked == true )//use
            {
                Dao dao = new Dao();
                //3种sql的写法目前选择方法2
                //string sql = "select * from users where uId = '" + textBox1.Text + "' and uPsw ='" + textBox2.Text + "'";
                string sql2 = string.Format("select * from users where uId ='{0}'  and uPwd ='{1}'", textBox1.Text, textBox2.Text);
                //string sql3 = $"select *from users where uId = '{textBox1.Text}' and uPsw ='{textBox2.Text}'";
                IDataReader dc = dao.read(sql2);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功");
                    Data.UID = dc["uId"].ToString();
                    Data.UName = dc["uName"].ToString();

                    User1 user = new User1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("登陆失败");
                    return false;

                }
                MessageBox.Show(dc[0].ToString());

                //MessageBox.Show(sql2);
                //显示查询语句
               
            }
            if (radioButton2.Checked == true)//
            {
                Dao dao = new Dao();
                //3种sql的写法目前选择方法2
                //string sql = "select * from users where uId = '" + textBox1.Text + "' and uPsw ='" + textBox2.Text + "'";
                string sql2 = string.Format("select * from admin where aId ='{0}'  and aPwd ='{1}'", textBox1.Text, textBox2.Text);
                //string sql3 = $"select *from users where uId = '{textBox1.Text}' and uPsw ='{textBox2.Text}'";
                IDataReader dc = dao.read(sql2);
                if (dc.Read())
                {
                    Data.UID = dc["aId"].ToString();
                    Data.UName = dc["aName"].ToString();
                    MessageBox.Show("登录成功");
                  
                    Admin1 admin = new Admin1();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("登陆失败");
                    return false;

                }
                MessageBox.Show(dc[0].ToString());

                //MessageBox.Show(sql2);
                //显示查询语句
            }
            return true;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
