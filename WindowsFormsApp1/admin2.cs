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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
            table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void admin2_Load(object sender, EventArgs e)
        {

        }
        public void table() 
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from books";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin21 admin = new admin21();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }
    }
}
