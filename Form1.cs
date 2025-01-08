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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Crée une instance de Form2
            form2.Show();              // Affiche Form2
            this.Hide();               // Cache Form1 (optionnel)
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
