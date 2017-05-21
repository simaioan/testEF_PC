using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Predare
{
    public partial class HR_Project : Form
    {
        public HR_Project()
        {
            InitializeComponent();
        }

        private void acteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Acte f1 = new frm_Acte();
            f1.ShowDialog();
        }

        private void candidatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Angajati f1 = new frm_Angajati();
            f1.ShowDialog();
        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Angajati f1 = new frm_Angajati();
            f1.ShowDialog();
        }
        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cereriActeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cerere_Acte f5 = new frm_Cerere_Acte();
            f5.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pontareManualaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pontaje f = new frm_Pontaje();
            f.ShowDialog();
        }
    }
}
