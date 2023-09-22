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
    public partial class Predmeti : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();    
        DataTable dt_predmeti = new DataTable();
        SqlConnection veza;

        public Predmeti()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            dt_predmeti.Clear();
            veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS 'ID предмета', naziv AS 'Назив предмета', godina AS 'Година', semestar AS 'Семестар', " +
                "poruka AS 'Порука', espb AS 'Еспб', tezina AS 'Тежина' FROM Predmet", veza);
            adapter.Fill(dt_predmeti);
            grid_podaci.DataSource = dt_predmeti;
            grid_podaci.Columns["ID предмета"].Visible = false;
            grid_podaci.Columns["Порука"].Visible = false;

            if (grid_podaci.RowCount > 0)
            {
                btn_izmeni_predmet.Enabled = true;
                btn_obrisi_predmet.Enabled = true;
                grid_podaci.Rows[0].Selected = true;
                Klik_na_grid(0);
            }
            else
            {
                btn_izmeni_predmet.Enabled = false;
                btn_obrisi_predmet.Enabled = false;
                Klik_na_grid(-1);
            }
        }

        private void Klik_na_grid(int broj_sloga)
        {
            if (broj_sloga != -1)
            {
                txt_id.Text = dt_predmeti.Rows[broj_sloga]["ID предмета"].ToString();
                txt_naziv.Text = dt_predmeti.Rows[broj_sloga]["Назив предмета"].ToString();
                cmb_godina.SelectedItem = dt_predmeti.Rows[broj_sloga]["Година"];
                cmb_semestar.SelectedItem = dt_predmeti.Rows[broj_sloga]["Семестар"];
                txt_poruka.Text = dt_predmeti.Rows[broj_sloga]["Порука"].ToString();
                txt_espb.Text = dt_predmeti.Rows[broj_sloga]["Еспб"].ToString();
                cmb_tezina.SelectedItem = dt_predmeti.Rows[broj_sloga]["Тежина"];
            }
            else
            {
                txt_id.Text = "";
                txt_naziv.Text = "";
                cmb_godina.SelectedIndex = -1;
                cmb_semestar.SelectedIndex = -1;
                txt_poruka.Text = "";
                txt_espb.Text = "";
                cmb_tezina.SelectedIndex = -1;
            }
        }

        private void Predmeti_Load(object sender, EventArgs e)
        {                      
            foreach (DataGridViewColumn kolona in grid_podaci.Columns)
            {
                kolona.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 1; i <= 4; i++) cmb_godina.Items.Add(i);
            for (int i = 1; i <= 2; i++) cmb_semestar.Items.Add(i);
            for (int i = 1; i <= 3; i++) cmb_tezina.Items.Add(i);

            Osvezi();            
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void grid_podaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_podaci.CurrentRow != null)
            {
                int broj_sloga = grid_podaci.CurrentRow.Index;
                if (broj_sloga >= 0 && grid_podaci.RowCount != 0)
                {
                    Klik_na_grid(broj_sloga);
                }
            }
        }

        private void btn_unesi_predmet_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();

                SqlCommand komanda = new SqlCommand("Predmet_Insert", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@naziv", SqlDbType.NVarChar).Value = txt_naziv.Text;
                komanda.Parameters.AddWithValue("@godina", SqlDbType.Int).Value = cmb_godina.SelectedItem;
                komanda.Parameters.AddWithValue("@semestar", SqlDbType.Int).Value = cmb_semestar.SelectedItem;
                komanda.Parameters.AddWithValue("@espb", SqlDbType.Int).Value = txt_espb.Text;

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    if (povratna_vrednost == -1) MessageBox.Show("Дати предмет већ постоји!");
                    else MessageBox.Show("Дошло је до грешке: " + povratna_vrednost);
                }

                veza.Close();

                Osvezi();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btn_izmeni_predmet_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();

                SqlCommand komanda = new SqlCommand("Predmet_Update", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@naziv", SqlDbType.NVarChar).Value = txt_naziv.Text;
                komanda.Parameters.AddWithValue("@godina", SqlDbType.Int).Value = cmb_godina.SelectedItem;
                komanda.Parameters.AddWithValue("@semestar", SqlDbType.Int).Value = cmb_semestar.SelectedItem;
                komanda.Parameters.AddWithValue("@poruka", SqlDbType.NVarChar).Value = txt_poruka.Text;
                komanda.Parameters.AddWithValue("@espb", SqlDbType.Int).Value = txt_espb.Text;
                komanda.Parameters.AddWithValue("@tezina", SqlDbType.Int).Value = cmb_tezina.SelectedItem;

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    if (povratna_vrednost == -1) MessageBox.Show("Дати предмет не постоји!");
                    else MessageBox.Show("Дошло је до грешке!");
                }

                veza.Close();

                Osvezi();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btn_obrisi_predmet_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();

                SqlCommand komanda = new SqlCommand("Predmet_Delete", veza);
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.Parameters.AddWithValue("@naziv", SqlDbType.NVarChar).Value = txt_naziv.Text;

                var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                povratni_parametar.Direction = ParameterDirection.ReturnValue;

                komanda.ExecuteNonQuery();
                int povratna_vrednost = (int)povratni_parametar.Value;
                if (povratna_vrednost != 0)
                {
                    if (povratna_vrednost == -1)
                    {
                        MessageBox.Show("Дати предмет не постоји!");
                    }
                    else
                    {
                        MessageBox.Show("Грешка!");
                    }
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
