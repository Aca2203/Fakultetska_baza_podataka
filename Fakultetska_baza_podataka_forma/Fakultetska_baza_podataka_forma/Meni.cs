using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakultetska_baza_podataka_forma
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void сесијеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveraVeze())
            {
                Sesije forma = new Sesije((int)cmb_godina.SelectedItem, 0);
                forma.Show();
            }
            else
            {
                MessageBox.Show("Грешка!");
            }
        }        

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveraVeze())
            {
                Predmeti forma = new Predmeti();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Грешка!");
            }
        }

        private void сесијеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (proveraVeze())
            {
                Statistika_sesije forma = new Statistika_sesije();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Грешка!");
            }
        }

        private void датумиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveraVeze())
            {
                Datumi forma = new Datumi();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Грешка!");
            }
        }

        private void Meni_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++) cmb_godina.Items.Add(i);
            for (int i = 1; i <= 2; i++) cmb_semestar.Items.Add(i);
            cmb_godina.SelectedItem = 3;
            cmb_semestar.SelectedItem = 0;
        }

        private bool proveraVeze()
        {
            try
            {
                string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
                using (SqlConnection veza = new SqlConnection(CS))
                {
                    veza.Open();
                }
            }
            catch (SqlException e) { return false; }
            catch (Exception e) { return false; }

            return true;
        }
    }
}
