using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Fakultetska_baza_podataka_forma
{
    public partial class Form1 : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
        DataTable dt_sesije = new DataTable();
        DataTable dt_predmeti = new DataTable();
        SqlConnection veza;

        public Form1()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            dt_sesije.Clear();
            veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Sesija.id AS 'ID сесије', datum AS 'Датум сесије', Predmet.naziv AS 'Назив предмета', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', efikasnost AS 'Ефикасност' FROM Sesija JOIN Predmet ON Predmet.id = Sesija.fk_predmet ORDER BY datum;", veza);
            adapter.Fill(dt_sesije);
            grid_podaci.DataSource = dt_sesije;

            dt_predmeti.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM Predmet", veza);
            adapter.Fill(dt_predmeti);
            cmb_predmet.DataSource = dt_predmeti;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvezi();           
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void grid_podaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
