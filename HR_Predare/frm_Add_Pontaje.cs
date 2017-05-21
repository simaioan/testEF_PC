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
    public partial class frm_Add_Pontaje : Form
    {
        public frm_Add_Pontaje()
        {
            InitializeComponent();
        }

        private void button_pontaj_Click(object sender, EventArgs e)
        {
             try
            {
                using (HREntities hr = new HREntities())
                {
                    pontaje p = hr.pontajes.FirstOrDefault(r => r.id_personal == (int)comboBox_nume.SelectedValue && 
                        r.date_out==null);
                    
                    //if (hr.pontajes.Any(r => r.Transaction == (int)comboBox_nume.SelectedValue))) return;//verificare daca exita randuri in BD
                    //pontaje interogare=from pontaje in hr.pontajes
                    //               where pontaje.id_personal==pontaje.id_personal
                    //               select pontaje;
                    if ((p == null) || (p.date_out!=null)){//adauga intrare noua
                        pontaje pont = new pontaje();
                        pont.id_personal = (int)comboBox_nume.SelectedValue;
                        pont.date_in = DateTime.Now; //dateTime_dateInPontaj.Value;
                        hr.pontajes.Add(pont);
                    }else{//salveaza dataout
                        p.date_out = DateTime.Now;
                    }
                    hr.SaveChanges();
                    MessageBox.Show("Pontaj salvat!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Add_Pontaje_Load(object sender, EventArgs e)
        {
            populate_combo();
            comboBox_nume.Select();
        }
        private void populate_combo()
        {
            try
            {
                using (HREntities hr = new HREntities())
                {
                    //var interogare = from personal in hr.personals
                    //                 orderby personal.name
                    //                 select new { personal.id, personal.name };

                    //var lista_nume = interogare.tolist();
                    //comboBox_nume.DataSource = interogare;
                    comboBox_nume.DataSource = hr.personals.ToList();
                    comboBox_nume.ValueMember = "id";
                    comboBox_nume.DisplayMember = "name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace + "\n\n" + ex.InnerException);
            }
        }
 //final form
    }
}