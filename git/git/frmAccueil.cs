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

        private void cours_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCours fc = new frmCours();
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEleves fe = new frmEleves();
            fe.Show();
        }
    }
}
