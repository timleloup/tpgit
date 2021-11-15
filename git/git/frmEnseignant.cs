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

                string queryUser = "Select * From prof";
                MySqlCommand select = new MySqlCommand(queryUser, connexion);
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {

                    Prof prof = new Prof();

                    prof.Id = reader.GetInt32("id");
                    prof.Nom = reader.GetString("nom");
                    prof.Prenom = reader.GetString("prenom");
                    prof.Adresse = reader.GetString("adresse");
                    prof.Tel = reader.GetString("tel");
                    prof.Mail = reader.GetString("mail");
                    prof.Dateembauche = reader.GetString("dateembauche");

                    Profs.Add(prof);
                }

                dgvProf.DataSource = Profs;


                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();


                addbtn.HeaderText = "Ajouter";
                addbtn.Text = "insérer";
                addbtn.UseColumnTextForButtonValue = true;


                dgvProf.Columns.Add(addbtn);



                DataGridViewButtonColumn updbtn = new DataGridViewButtonColumn();


                updbtn.HeaderText = "Modifier";
                updbtn.Text = "modifier";
                updbtn.UseColumnTextForButtonValue = true;


                dgvProf.Columns.Add(updbtn);



                DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();


                delbtn.HeaderText = "Supprimer";
                delbtn.Text = "supprimer";
                delbtn.UseColumnTextForButtonValue = true;

                dgvProf.Columns.Add(delbtn);



                dgvProf.CellContentClick += (s, a) =>
                {
                    if (dgvProf.Columns[a.ColumnIndex].HeaderText == "Ajouter")
                    {
                        MessageBox.Show("coucou");
                    }
                };

                dgvProf.CellContentClick += (s, a) =>
                {
                    if (dgvProf.Columns[a.ColumnIndex].HeaderText == "Modifier")
                    {
                        MessageBox.Show("update");
                    }
                };

                dgvProf.CellContentClick += (s, a) =>
                {
                    if (dgvProf.Columns[a.ColumnIndex].HeaderText == "Supprimer")
                    {
                        if (MessageBox.Show("Suppr ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                            

                            MessageBox.Show(a.ToString());
                            
                        }
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
