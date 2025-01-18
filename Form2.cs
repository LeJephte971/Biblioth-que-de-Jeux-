using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string connectionString = "Server=mysql-crabes-projet.alwaysdata.net;Database=crabes-projet_971;"+
                                      "User ID=391593_josephjef;Password=Jojomadoo971;";
            try
            {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    // Tenter d'ouvrir la connexion
                    conn.Open();

                    // Message de succès
                    MessageBox.Show("Connexion réussie à la base de données !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*---> Faire une requête SELECT afin de rechercher dans la base de données l'utilisateur ayant
                 le nom (variable user) et mot de passe (variable mdp) saisis.
                 Récupérer grâce à ce select le type d'utilisateur */
                string query = "SELECT role_id FROM users WHERE username = '" + user + "' and mot_de_passe = '" + mdp + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                int role = (int)cmd.ExecuteScalar();
                MessageBox.Show("Bienvenue dans la Bibliothèque de jeux ! ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == 1)
                {
                    FrmLstJeux frmLstJeux = new FrmLstJeux(conn); // Crée une instance de FrmLstJeux
                    frmLstJeux.Show();  // Affiche FrmLstJeux
                    this.Hide();
                }
                else
                {
                    ViewUser viewUser = new ViewUser(conn); // Crée une instance de ViewUser
                    viewUser.Show();  // Affiche ViewUser
                    this.Hide();
                }
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
    }
}
