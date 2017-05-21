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
    public partial class frm_Add_acte : Form
    {
        bool editare;
        int id_edit;
        public frm_Add_acte()
        {
            InitializeComponent();
        }
        public frm_Add_acte(bool edit, int id_var)
        {
            editare = edit;
            id_edit = id_var;
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (editare)
            {
                /*
                ent.actes.FirstOrDefault(r => r.id == 1);
                acte a = new acte();
                a.denumire = textBox_denumire.Text;
                a.continut = textBox_link.Text;
                ent.SaveChanges();
                */
                try
                {
                    using (HREntities ent = new HREntities())
                    {
                        acte act = ent.actes.FirstOrDefault(r => r.id == id_edit);
                        if (act != null)
                        {
                            act.denumire = textBox_denumire.Text;
                            act.continut=textBox_link.Text;
                            ent.SaveChanges();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                }
            }
            else
            {
                /*HREntities ent= new HREntities();
                acte a = new acte();
                a.denumire = textBox_denumire.Text;
                a.continut = textBox_link.Text;

                ent.actes.Add(a);
                ent.SaveChanges();*/
                try
                {
                    using (HREntities ent = new HREntities())
                    {
                        acte act = new acte
                        {
                            denumire = textBox_denumire.Text,
                            continut = textBox_link.Text,
                        };
                        ent.actes.Add(act);
                        ent.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                   // throw;
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                } finally {
                    //release daca e cazul
                }
            }
            this.Close();
        }

        private void frm_Add_acte_Load(object sender, EventArgs e)
        {
            if (editare)
            {//pentru editare
                try{
                    this.Text = "Modificare act";
                    using(HREntities hr=new HREntities()){
                        acte act = hr.actes.FirstOrDefault(r => r.id == id_edit);
                        if (act!=null)
                        {
                            textBox_denumire.Text = act.denumire.ToString();
                            textBox_link.Text = act.continut.ToString();
                        }
                    }
                }catch(Exception ex){
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                }
            }
            else
            {
                //pt adaugare
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            //pt deschidere fisier si preluarea caii si denumirii
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Toate fisierele|*.*";
            of.Title = "Selectati un fisier";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox_link.Text = of.FileName;
            }  
        }
    }
}