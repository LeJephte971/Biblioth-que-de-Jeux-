using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_jeux
{
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
           
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connecte connecte = new Connecte(); 
            connecte.Show();              
            this.Hide();               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewUser ViewUser = new ViewUser(); 
            ViewUser.Show();             
            this.Hide();
        }
    }
}
