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

    public partial class frm_Acte : Form
    {

        public frm_Acte()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView.CurrentCell.RowIndex;//return nr randului selectat , incepe cu 0
                int id_act = (int)dataGridView.Rows[rowindex].Cells[0].Value;//returneaza id-ul randului selectat
                frm_Add_acte f = new frm_Add_acte(true, id_act);
                f.ShowDialog();
                if (f.DialogResult==DialogResult.OK) {
                    grid_list();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
            }
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Acte_Load(object sender, EventArgs e)
        {
            grid_list();
            dataGridView.Select();
        }

        private void frm_Acte_Resize(object sender, EventArgs e)
        {
            //dataGridView.Width=this.Scale
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            frm_Add_acte f = new frm_Add_acte();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                grid_list();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sigur stergeti?", "Stergere") == DialogResult.OK)
                {
                    /* functioneaza la fel
                    MessageBox.Show(dataGridView.Rows.Count.ToString());
                    MessageBox.Show(dataGridView.Columns.Count.ToString());
                    MessageBox.Show(dataGridView.RowCount.ToString());
                    MessageBox.Show(dataGridView.ColumnCount.ToString());
                     * */
                    //MessageBox.Show(dataGridView.SelectedCells[0].RowIndex.ToString());//return nr rand , incepe cu 0
                    int rowindex = dataGridView.CurrentCell.RowIndex;//return nr rand , incepe cu 0
                    //int columnindex= dataGridView.CurrentCell.ColumnIndex; 
                    //MessageBox.Show(dataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());//return continutul celulei curente
                    int id_act = (int)dataGridView.Rows[rowindex].Cells[0].Value;//returneaza id-ul randului selectat
                    using (HREntities hr = new HREntities())
                    {
                        acte act = hr.actes.FirstOrDefault(r => r.id == id_act);
                        if (act != null)
                        {
                            hr.actes.Remove(act);
                            hr.SaveChanges();
                            grid_list();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
            }
        }

        private void grid_list()
        {
            try
            {
                using (HREntities hr = new HREntities())
                {
                    //pt editarea in Grid
                    //BindingSource bs = new BindingSource();

                    /*
                    var interogare = from act in hr.actes //interogarre de tip Linq
                                        orderby act.id
                                        select act;
                        * * varianta asta da eroare pentru ca incearca sa extraga si istoric cereri
                        */
                    var interogare = from act in hr.actes //interogarre de tip Linq
                                     orderby act.id
                                     select new { act.id, act.denumire, act.continut };

                    var lista_acte = interogare.ToList();
                    //bs.DataSource = interogare.ToList();
                    //dataGridView.DataSource = bs;
                    dataGridView.DataSource = lista_acte;
                    //doar aici exista deja coloanele
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Width = 300;
                    dataGridView.Columns[2].Width = 700;
                    /*
                    foreach (var item in interogare)
                    {
                        MessageBox.Show(item.denumire + item.continut);
                    }*/
                    //sau - asta permite editarea dar nu se salveaza
                    //dataGridView.DataSource = hr.actes.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace + "\n\n" + ex.InnerException);
            }
        }
    }
}
