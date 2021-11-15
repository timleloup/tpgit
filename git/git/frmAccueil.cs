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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void gestionClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClasses fp = new frmClasses();
            fp.Show();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalle fs = new frmSalle();
            fs.Show();

        }

        private void GestionEnseignant_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnseignant fs = new frmEnseignant();
            fs.Show();
        }
    }
}
