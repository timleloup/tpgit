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

namespace git
{
    public partial class frmEnseignant : Form
    {
        public frmEnseignant()
        {
            InitializeComponent();
        }


        private static MySqlConnection Connexion()
        {
            MySqlConnection connexion = new MySqlConnection("server = localhost;" +
                "database=tpgit;" +
                "port=3306;" +
                "user=root;" +
                "password=;" +
                "SSL Mode=None");


            return connexion;
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccueil fp = new frmAccueil();
            fp.Show();
        }

        private void frmEnseignant_Load(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection();

            connexion = Connexion();
            connexion.Open();
            List<Prof> Profs = new List<Prof>();

            try
            {

                string queryUser = "Select id,nom From prof";
                MySqlCommand select = new MySqlCommand(queryUser, connexion);
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {

                    Prof prof = new Prof();

                    prof.Id = reader.GetInt32("id");
                    prof.Nom = reader.GetString("nom");
                    prof.Nom = reader.GetString("prenom");
                    prof.Nom = reader.GetString("adresse");
                    prof.Nom = reader.GetString("tel");
                    prof.Nom = reader.GetString("mail");
                    prof.Nom = reader.GetString("dateembauche");

                    Profs.Add(prof);
                }

                dgvProf.DataSource = Profs;
                dgvProf.Columns.Add("button", "btn");


            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
            }
        }
    }
}
