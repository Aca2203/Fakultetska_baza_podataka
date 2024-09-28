using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Sesije forma = new Sesije((int) cmb_godina.SelectedItem, (int) cmb_semestar.SelectedItem);
            forma.Show();
        }

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Predmeti forma = new Predmeti();
            forma.Show();
        }

        private void сесијеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Statistika_sesije forma = new Statistika_sesije();
            forma.Show();
        }

        private void датумиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datumi forma = new Datumi();
            forma.Show();
        }

        private void Meni_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++) cmb_godina.Items.Add(i);
            for (int i = 1; i <= 2; i++) cmb_semestar.Items.Add(i);
            cmb_godina.SelectedItem = 3;
            cmb_semestar.SelectedItem = 1;
        }
    }
}
