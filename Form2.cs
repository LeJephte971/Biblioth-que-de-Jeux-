using MySql.Data.MySqlClient;
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
    public partial class Connecte : Form 
    {
        public Connecte()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtId.Text;
            string mdp = txtMdp.Text;

            // Chaîne de connexion (assurez-vous que les identifiants sont corrects)
            string connectionString = "Server=mysql-crabes-projet.alwaysdata.net;Database=crabes-projet_971;" +
              //"User ID="+user+";Password="+mdp+";";
            "User ID=391593_josephjef;Password=Jojomadoo971;";
            try
            {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    // Tenter d'ouvrir la connexion
                    conn.Open();

                    // Message de succès
                    MessageBox.Show("Connexion réussie à la base de données !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLstJeux frmLstJeux = new FrmLstJeux(conn); // Crée une instance de Form3
                    frmLstJeux.Show();              // Affiche Form3
                    this.Hide();               // Cache Form1 (optionnel)
            }
            catch (Exception ex)
            {
            // Afficher l'erreur en cas d'échec
                    MessageBox.Show($"Erreur ; lors de la connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewUser ViewUser = new ViewUser(); // Crée une instance de Form2
            ViewUser.Show();              // Affiche Form2
            this.Hide();               // Cache Form1 (optionnel)
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Connecte connecte = new Connecte(); // Crée une instance de Form2
            connecte.Show();              // Affiche Form2
            this.Hide();               // Cache Form1 (optionnel)
        }
    }
}
