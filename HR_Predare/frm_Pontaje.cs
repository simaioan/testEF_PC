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
    
    public partial class frm_Pontaje : Form
    {
        public frm_Pontaje()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            frm_Add_Pontaje f = new frm_Add_Pontaje();
            f.ShowDialog();
        }
    }
    }

