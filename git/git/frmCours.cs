using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace git
{
    public partial class frmCours : Form
    {
        public frmCours()
        {
            InitializeComponent();
        }

        string host = "localhost";
        int port = 3308;
        string database = "tpgit";
        string username = "root";
        string password = "";
        string SSLmode = "None";

        DataSet ds = new DataSet();

        public static MySqlConnection connexion(string host, string SSLmode, int port, string database, string username, string password)
        {

            String connString = "Server=" + host + ";Database=" + database
              + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SSL MODE=" + SSLmode;


            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccueil fp = new frmAccueil();
            fp.Show();
        }

      

        private void frmCours_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = connexion(host, SSLmode, port, database, username, password);
            SqlCommand com = new SqlCommand();
            MySqlDataAdapter da;
            try
            {

                //Create SqlConnection

                List<cours> Cour = new List<cours>();

                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();

                cmd.CommandText = "Select * from cours";
                MySqlDataReader emp = cmd.ExecuteReader();
                while (emp.Read())
                {
                    cours monCours = new cours();
                    monCours.Id = emp.GetInt32("id");
                    monCours.Idmatiere = emp.GetInt32("idmatiere");
                    monCours.Date = emp.GetString("date");
                    monCours.Heure = emp.GetString("heure");
                    monCours.Duree = emp.GetString("duree");
                    monCours.Idprof = emp.GetInt32("idprof");
                    monCours.Idsalle = emp.GetInt32("idsalle");
                    monCours.Idclasse = emp.GetInt32("idclasse");

                    Cour.Add(monCours);

                }



                dgvClasses.DataSource = Cour;

               

                DataGridViewButtonColumn dgvbts = new DataGridViewButtonColumn();

                dgvbts.HeaderText = "supprimer";
                dgvbts.Text = "supprimer";
                dgvbts.UseColumnTextForButtonValue = true;

                dgvClasses.Columns.Add(dgvbts);

                  dgvClasses.CellContentClick += (s, a) =>
                {
                    if (dgvClasses.Columns[a.ColumnIndex].HeaderText == "supprimer")
                    {

                        if (MessageBox.Show("supp?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                       ) { 
                        
                        
                        }

                    }
                };

              

                DataGridViewButtonColumn dgvbtss = new DataGridViewButtonColumn();

                dgvbtss.HeaderText = "modifier";
                dgvbtss.Text = "modifer";
                dgvbtss.UseColumnTextForButtonValue = true;

                dgvClasses.Columns.Add(dgvbtss);

                dgvClasses.CellContentClick += (s, a) =>
                {
                    if (dgvClasses.Columns[a.ColumnIndex].HeaderText == "modifier")
                    {

                        MessageBox.Show("ok");


                    }
                };

                DataGridViewButtonColumn dgvbtsss = new DataGridViewButtonColumn();

                dgvbtsss.HeaderText = "liste eleve";
                dgvbtsss.Text = "liste eleve";
                dgvbtsss.UseColumnTextForButtonValue = true;

                dgvClasses.Columns.Add(dgvbtsss);

                dgvClasses.CellContentClick += (s, a) =>
                {
                    if (dgvClasses.Columns[a.ColumnIndex].HeaderText == "liste eleve")
                    {

                        MessageBox.Show("ok");


                    }
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


         


            connect.Close();
        }
    }
}
