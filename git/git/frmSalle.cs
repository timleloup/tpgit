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
    public partial class frmSalle : Form

    {



        public frmSalle()
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccueil fp = new frmAccueil();
            fp.Show();
        }

        private void frmSalle_Load(object sender, EventArgs e)
        {
            
            MySqlConnection connexion = new MySqlConnection();

            connexion = Connexion();
            connexion.Open();
            List<Salle> Salles = new List<Salle>();

            try
            {

                string queryUser = "Select id,nom From salle";
                MySqlCommand select = new MySqlCommand(queryUser, connexion);
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {

                    Salle Salle = new Salle();

                    Salle.Id = reader.GetInt32("id");
                    Salle.Nom = reader.GetString("nom");

                    Salles.Add(Salle);
                }

                dgvSalle.DataSource = Salles;
                dgvSalle.Columns.Add("button","btn");


            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
            }

        }
    }

}

