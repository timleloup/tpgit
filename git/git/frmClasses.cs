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
    public partial class frmClasses : Form
    {
        public frmClasses()
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

        
      
           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClasses_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = connexion(host, SSLmode, port, database, username, password);
            SqlCommand com = new SqlCommand();
            MySqlDataAdapter da;
            try
            {

                //Create SqlConnection

                List<Classes> Classe = new List<Classes>();

                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();

                cmd.CommandText = "Select * from classes";
                MySqlDataReader emp = cmd.ExecuteReader();
                while (emp.Read())
                {
                    Classes maClasse = new Classes();
                    maClasse.Id = emp.GetInt32("id");
                    maClasse.Numero = emp.GetString("numero");

                    Classe.Add(maClasse);

                }



                dgvClasses.DataSource = Classe;

              

                DataGridViewButtonColumn dgvbts = new DataGridViewButtonColumn();

                dgvbts.HeaderText = "supprimer";
                dgvbts.Text = "supprimer";
                dgvbts.UseColumnTextForButtonValue = true;

                dgvClasses.Columns.Add(dgvbts);

                dgvClasses.CellContentClick += (s, a) =>
                {
                    if (dgvClasses.Columns[a.ColumnIndex].HeaderText == "supprimer")
                    {

                        MessageBox.Show("ok");


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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccueil fp = new frmAccueil();
            fp.Show();
        }

    }
    }

