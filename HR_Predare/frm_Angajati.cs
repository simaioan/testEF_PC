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
    public partial class frm_Angajati : Form
    {
        public frm_Angajati()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            frm_Add_angajati f2 = new frm_Add_angajati();
            f2.ShowDialog();
      
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            frm_Add_angajati f2 = new frm_Add_angajati();
            f2.ShowDialog();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
