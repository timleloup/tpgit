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

                
                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();


                addbtn.HeaderText = "Ajouter";
                addbtn.Text = "insérer";                        
                addbtn.UseColumnTextForButtonValue = true;


                dgvSalle.Columns.Add(addbtn);



                DataGridViewButtonColumn updbtn = new DataGridViewButtonColumn();


                updbtn.HeaderText = "Modifier";
                updbtn.Text = "modifier";       
                updbtn.UseColumnTextForButtonValue = true;


                dgvSalle.Columns.Add(updbtn);



                DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();


                delbtn.HeaderText = "Supprimer";
                delbtn.Text = "supprimer";                        
                delbtn.UseColumnTextForButtonValue = true;

                dgvSalle.Columns.Add(delbtn);
                


                dgvSalle.CellContentClick += (s, a) =>
                {
                    if (dgvSalle.Columns[a.ColumnIndex].HeaderText  == "Ajouter")
                    {
                        MessageBox.Show("coucou");
                    }
                };

                dgvSalle.CellContentClick += (s, a) =>
                {
                    if (dgvSalle.Columns[a.ColumnIndex].HeaderText  == "Modifier")
                    {
                        MessageBox.Show("update");
                    }
                };

                dgvSalle.CellContentClick += (s, a) =>
                {
                    if (dgvSalle.Columns[a.ColumnIndex].HeaderText  == "Supprimer")
                    {
                        MessageBox.Show("suppr");
                    }
                };

            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
            }

        }

       
    }

}

