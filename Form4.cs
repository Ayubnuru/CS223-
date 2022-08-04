using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBankAccount
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mainpage = new Form2();
            mainpage.MdiParent = this;
            mainpage.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mainpage = new Form2();
            mainpage.MdiParent = this;
            mainpage.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mainpage = new Form2();
            mainpage.MdiParent = this;
            mainpage.Show();
        }
    }
}
