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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Sesija.fk_predmet AS 'ID предмета', Sesija.poruka AS 'Порука', Sesija.id AS 'ID сесије', " +
                "datum AS 'Датум сесије', Predmet.naziv AS 'Назив предмета', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', " +
                "ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', efikasnost AS 'Ефикасност' FROM Sesija JOIN Predmet ON " +
                "Predmet.id = Sesija.fk_predmet ORDER BY datum, vreme_pocetka;", veza);
            adapter.Fill(dt_sesije);
            grid_podaci.DataSource = dt_sesije;
            grid_podaci.Columns["ID сесије"].Visible = false;
            grid_podaci.Columns["ID предмета"].Visible = false;
            grid_podaci.Columns["Порука"].Visible = false;

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
            if(grid_podaci.CurrentRow != null)
            {
                int broj_sloga = grid_podaci.CurrentRow.Index;
                if (broj_sloga >= 0 && grid_podaci.RowCount != 0)
                {
                    txt_id.Text = dt_sesije.Rows[broj_sloga]["ID сесије"].ToString();
                    cmb_predmet.SelectedValue = dt_sesije.Rows[broj_sloga]["ID предмета"];
                    datum.Value = Convert.ToDateTime(dt_sesije.Rows[broj_sloga]["Датум сесије"]);
                    txt_vreme_pocetka.Text = dt_sesije.Rows[broj_sloga]["Време почетка"].ToString();
                    txt_vreme_zavrsetka.Text = dt_sesije.Rows[broj_sloga]["Време завршетка"].ToString();
                    txt_ukupno_vreme.Text = dt_sesije.Rows[broj_sloga]["Укупно време"].ToString();
                    txt_efektivno_vreme.Text = dt_sesije.Rows[broj_sloga]["Ефективно време"].ToString();
                    txt_poruka.Text = dt_sesije.Rows[broj_sloga]["Порука"].ToString();
                }
            }
        }
    }
}
