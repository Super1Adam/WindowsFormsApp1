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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin2 admin = new admin2();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
    }
}
