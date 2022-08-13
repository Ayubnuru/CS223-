using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace useradmin
{
    public partial class Assignment : Form
    {
        public Assignment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
            label1.BackColor = Color.Red; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            label2.BackColor = Color.Blue;  
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
            label3.BackColor = Color.Green; 
        }
       
        
        private void Assignment_Load(object sender, EventArgs e) {
            List<string> temporary = new List<string>() { "item 1", "Item2", "Item3" };
            temporary[2] = "demopractice";

            foreach (var item in temporary)
            {
             
                UserControl1 userC = new UserControl1();
               userC.MyProperty = item;
                 
                flowLayoutPanel1.Controls.Add(userC);
                //MessageBox.Show(item[2]);
            }
        }
    }
}
