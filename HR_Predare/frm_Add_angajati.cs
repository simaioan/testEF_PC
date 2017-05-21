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
    public partial class frm_Add_angajati : Form
    {
        bool emplo;
        public frm_Add_angajati()
        {
            InitializeComponent();
        }
        public frm_Add_angajati(bool empl)
        {
            InitializeComponent();
        }

        private void checkBox_sexF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (emplo)
            {
                //////////////////// Utilizare tranzactii 
                /*
                using (HREntities hr = new HREntities())
                {
                    using (var dbContextTransaction = hr.Database.BeginTransaction())
                    {
                        try
                        {
                            hr.Database.ExecuteSqlCommand(
                                @"UPDATE Blogs SET Rating = 5" +
                                    " WHERE Name LIKE '%Entity Framework%'"
                                );

                            var query = hr.actes.Where(p => p.Blog.Rating >= 5);
                            foreach (var post in query)
                            {
                                post.Title += "[Cool Blog]";
                            }

                            hr.SaveChanges();

                            dbContextTransaction.Commit();
                        }
                        catch (Exception)
                        {
                            dbContextTransaction.Rollback();
                        }
                    }
                } 
                */
                //////////////////
                HREntities ent = new HREntities();
                ent.actes.FirstOrDefault(r => r.id == 1);
                personal b = new personal();
                employee a = new employee();
                trainer c = new trainer();
                candidate d = new candidate();
                b.name = textBox_nume.Text;
                int x = 0;
                Int32.TryParse(textBox_telefon.Text, out x);
                b.phone = x;
                b.address = textBox_adresa.Text;
                int y = 0;
                Int32.TryParse(textBox_cnp.Text, out y);
                b.CNP = y;
                b.email = textBox_email.Text;
                b.civilst = textBox_starecivila.Text;
                b.depart = textBox_departament.Text;
                b.sex = checkBox_sexM.Text;
                b.sex = checkBox_sexF.Text;
                b.username = textBox_numeutilizator.Text;
                b.pass = textBox_parola.Text;
                //nu am stiut sa convertim datetime in string :(!!

                //a.data_in = dateTime_dataangajarii.Text;
                //a.data_in = dateTime_dataplecarii.Text;
                // c.schedule = textBox_orarTraining;
                // c.beginning = dateTime_inceputTraining.Text;
                // c.finish = dateTime_sfarsitTraining.Text;
                d.CV = textBox_cv.Text;//aici ar trebui un buton de upload, dar nu am reusit sa-l facem...


                ent.SaveChanges();
            }

            else

            {

                HREntities ent = new HREntities();
                personal b = new personal();
                employee a = new employee();
                trainer c = new trainer();
                candidate d = new candidate();
                b.name = textBox_nume.Text;
                int x = 0;
                Int32.TryParse(textBox_telefon.Text, out x);
                b.phone = x;
                b.address = textBox_adresa.Text;
                int y = 0;
                Int32.TryParse(textBox_cnp.Text, out y);
                b.CNP = y;
                b.email = textBox_email.Text;
                b.civilst = textBox_starecivila.Text;
                b.depart = textBox_departament.Text;
                b.sex = checkBox_sexM.Text;
                b.sex = checkBox_sexF.Text;
                b.username = textBox_numeutilizator.Text;
                b.pass = textBox_parola.Text;
                //nu am stiut sa convertim datetime in string :(!!

                //a.data_in = dateTime_dataangajarii.Text;
                //a.data_in = dateTime_dataplecarii.Text;
                // c.schedule = textBox_orarTraining;
                // c.beginning = dateTime_inceputTraining.Text;
                // c.finish = dateTime_sfarsitTraining.Text;
                d.CV = textBox_cv.Text;

                ent.employees.Add(a);
                ent.personals.Add(b);
                ent.trainers.Add(c);
                ent.candidates.Add(d);
                ent.SaveChanges();


            }
            this.Close();
        }

        private void frm_Add_angajati_Load(object sender, EventArgs e)
        {
            if (emplo)
            {
                this.Text = "Modificare act";
            }
            else
            {
                //adauga

            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
