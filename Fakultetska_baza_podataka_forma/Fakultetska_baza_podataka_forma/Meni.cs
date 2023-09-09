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
            Sesije forma = new Sesije();
            forma.Show();
        }

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Predmeti forma = new Predmeti();
            forma.Show();
        }
    }
}
