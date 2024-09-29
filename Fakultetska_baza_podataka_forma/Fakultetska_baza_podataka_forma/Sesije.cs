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
    public partial class Sesije : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
        DataTable dt_sesije = new DataTable();
        DataTable dt_predmeti = new DataTable();
        DataTable dt_mesta = new DataTable();
        SqlConnection veza;
        int godina, semestar;

        public Sesije(int godina, int semestar)
        {
            InitializeComponent();
            this.godina = godina;
            this.semestar = semestar;
        }

        private void Osvezi()
        {
            dt_sesije.Clear();
            veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Sesija.id AS 'ID сесије', datum AS 'Датум сесије', Mesto.id AS 'ID места', Mesto.naziv AS 'Место сесије', Predmet.id AS 'ID предмета', Predmet.naziv AS 'Назив предмета', vreme_pocetka AS 'Време почетка', vreme_zavrsetka AS 'Време завршетка', ukupno_vreme AS 'Укупно време', efektivno_vreme AS 'Ефективно време', CAST(efikasnost AS VARCHAR) + '%' AS 'Ефикасност', Sesija.poruka AS 'Порука' FROM Sesija LEFT JOIN Predmet ON Predmet.id = Sesija.fk_predmet LEFT JOIN Mesto ON Mesto.id = Sesija.fk_mesto WHERE Predmet.godina = " + godina + " AND Predmet.semestar = " + semestar + " ORDER BY datum DESC, vreme_pocetka DESC;", veza);
            adapter.Fill(dt_sesije);
            grid_podaci.DataSource = dt_sesije;
            grid_podaci.Columns["ID сесије"].Visible = false;
            grid_podaci.Columns["ID предмета"].Visible = false;
            grid_podaci.Columns["ID места"].Visible = false;
            grid_podaci.Columns["Порука"].Visible = false;

            dt_predmeti.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM Predmet WHERE godina = " + godina + " AND semestar = " + semestar, veza);
            adapter.Fill(dt_predmeti);
            cmb_predmet.DataSource = dt_predmeti;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";

            dt_mesta.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM Mesto", veza);
            adapter.Fill(dt_mesta);
            cmb_mesto.DataSource = dt_mesta;
            cmb_mesto.ValueMember = "id";
            cmb_mesto.DisplayMember = "naziv";

            if (grid_podaci.RowCount > 0)
            {
                btn_izmeni_sesiju.Enabled = true;
                btn_obrisi_sesiju.Enabled = true;
                grid_podaci.Rows[0].Selected = true;
                Klik_na_grid(0);
            }
            else
            {
                btn_izmeni_sesiju.Enabled = false;
                btn_obrisi_sesiju.Enabled = false;
                Klik_na_grid(-1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvezi();

            foreach (DataGridViewColumn kolona in grid_podaci.Columns)
            {
                kolona.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();            
        }

        private void Klik_na_grid(int broj_sloga)
        {
            if (broj_sloga != -1)
            {
                txt_id.Text = dt_sesije.Rows[broj_sloga]["ID сесије"].ToString();
                cmb_predmet.SelectedValue = dt_sesije.Rows[broj_sloga]["ID предмета"];
                cmb_mesto.SelectedValue = dt_sesije.Rows[broj_sloga]["ID места"];
                datum.Value = Convert.ToDateTime(dt_sesije.Rows[broj_sloga]["Датум сесије"]);
                txt_vreme_pocetka.Text = dt_sesije.Rows[broj_sloga]["Време почетка"].ToString();
                txt_vreme_zavrsetka.Text = dt_sesije.Rows[broj_sloga]["Време завршетка"].ToString();
                txt_ukupno_vreme.Text = dt_sesije.Rows[broj_sloga]["Укупно време"].ToString();
                txt_efektivno_vreme.Text = dt_sesije.Rows[broj_sloga]["Ефективно време"].ToString();
                txt_poruka.Text = dt_sesije.Rows[broj_sloga]["Порука"].ToString();
            }
            else
            {
                txt_id.Text = "";
                cmb_predmet.SelectedValue = -1;
                cmb_mesto.SelectedValue = -1;
                datum.Value = DateTime.Now;
                txt_vreme_pocetka.Text = "";
                txt_vreme_zavrsetka.Text = "";
                txt_ukupno_vreme.Text = "";
                txt_efektivno_vreme.Text = "";
                txt_poruka.Text = "";
            }
        }

        private void grid_podaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grid_podaci.CurrentRow != null)
            {
                int broj_sloga = grid_podaci.CurrentRow.Index;
                if (broj_sloga >= 0 && grid_podaci.RowCount != 0)
                {
                    Klik_na_grid(broj_sloga);
                }
            }
        }

        private void btn_unesi_sesiju_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();

                SqlCommand komanda = new SqlCommand("Sesija_Insert", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@fk_predmet", SqlDbType.Int).Value = cmb_predmet.SelectedValue;
                komanda.Parameters.AddWithValue("@datum", SqlDbType.Date).Value = datum.Value;
                komanda.Parameters.AddWithValue("@fk_mesto", SqlDbType.Int).Value = cmb_mesto.SelectedValue;
                komanda.Parameters.AddWithValue("@vreme_pocetka", SqlDbType.Time).Value = txt_vreme_pocetka.Text;
                komanda.Parameters.AddWithValue("@vreme_zavrsetka", SqlDbType.Time).Value = txt_vreme_zavrsetka.Text;
                komanda.Parameters.AddWithValue("@ukupno_vreme", SqlDbType.Time).Value = txt_ukupno_vreme.Text;
                komanda.Parameters.AddWithValue("@efektivno_vreme", SqlDbType.Time).Value = txt_efektivno_vreme.Text;
                komanda.Parameters.AddWithValue("@poruka", SqlDbType.NVarChar).Value = txt_poruka.Text;

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    MessageBox.Show("Дошло је до грешке!");
                }

                veza.Close();

                Osvezi();
            }            
            catch (Exception greska){
                MessageBox.Show(greska.Message);
            }
        }

        private void btn_izmeni_sesiju_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();                

                SqlCommand komanda = new SqlCommand("Sesija_Update", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@id", SqlDbType.Int).Value = txt_id.Text;
                komanda.Parameters.AddWithValue("@fk_predmet", SqlDbType.Int).Value = cmb_predmet.SelectedValue;
                komanda.Parameters.AddWithValue("@datum", SqlDbType.Date).Value = datum.Value;
                komanda.Parameters.AddWithValue("@fk_mesto", SqlDbType.Int).Value = cmb_mesto.SelectedValue;
                komanda.Parameters.AddWithValue("@vreme_pocetka", SqlDbType.Time).Value = txt_vreme_pocetka.Text;
                komanda.Parameters.AddWithValue("@vreme_zavrsetka", SqlDbType.Time).Value = txt_vreme_zavrsetka.Text;
                komanda.Parameters.AddWithValue("@ukupno_vreme", SqlDbType.Time).Value = txt_ukupno_vreme.Text;
                komanda.Parameters.AddWithValue("@efektivno_vreme", SqlDbType.Time).Value = txt_efektivno_vreme.Text;
                komanda.Parameters.AddWithValue("@poruka", SqlDbType.NVarChar).Value = txt_poruka.Text;

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    MessageBox.Show("Дошло је до грешке!");
                }

                veza.Close();
                              
                Osvezi();                
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btn_obrisi_sesiju_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();

                SqlCommand komanda = new SqlCommand("Sesija_Delete", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@id", SqlDbType.Int).Value = txt_id.Text;              

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    MessageBox.Show("ID сесије је погрешан!");
                }

                veza.Close();

                Osvezi();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
    }
}
