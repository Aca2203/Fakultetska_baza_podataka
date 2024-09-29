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
using System.Windows.Forms.DataVisualization.Charting;

namespace Fakultetska_baza_podataka_forma
{
    public partial class Statistika_sesije : Form
    {
        SqlConnection veza;
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
        DataTable tabela = new DataTable();
        DataTable predmeti = new DataTable();
        DataTable mesta = new DataTable();

        public Statistika_sesije()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            tabela.Clear();            
            SqlDataAdapter adapter = new SqlDataAdapter();            
            veza = new SqlConnection(CS);
            veza.Open();
            SqlCommand komanda;            
            if (cmb_predmet.SelectedIndex == 0)
                if (cmb_mesto.SelectedIndex == 0)
                {                    
                    adapter = new SqlDataAdapter("SELECT CONVERT(VARCHAR, Datum.datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Datum LEFT JOIN Sesija ON Datum.datum = Sesija.datum WHERE Datum.datum >= '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "' AND Datum.datum <= '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "' GROUP BY Datum.datum;", veza);                    
                }
                else
                    adapter = new SqlDataAdapter("EXEC prikaz @id_predmeta = 0, @id_mesta = " + cmb_mesto.SelectedValue + ", @datum_pocetka = '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "', @datum_zavrsetka = '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "'", veza);
            else
                if (cmb_mesto.SelectedIndex == 0)
                adapter = new SqlDataAdapter("EXEC prikaz @id_predmeta = " + cmb_predmet.SelectedValue + ", @id_mesta = 0, @datum_pocetka = '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "', @datum_zavrsetka = '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "'", veza);
            else
                adapter = new SqlDataAdapter("EXEC prikaz @id_predmeta = " + cmb_predmet.SelectedValue + ", @id_mesta = " + cmb_mesto.SelectedValue + ", @datum_pocetka = '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "', @datum_zavrsetka = '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "'", veza);

            adapter.Fill(tabela);
            grafikon.DataSource = tabela;    
            grafikon.DataBind();

            if (cmb_predmet.SelectedIndex == 0 && cmb_mesto.SelectedIndex == 0)
            {
                komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) FROM Sesija WHERE datum >= '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "' AND datum <= '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "';", veza);
                txt_ukupno_vreme.Text = komanda.ExecuteScalar().ToString();
                komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) FROM Sesija WHERE datum >= '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "' AND datum <= '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "';", veza);
                txt_efektivno_vreme.Text = komanda.ExecuteScalar().ToString();
                //MessageBox.Show("SELECT dbo.efikasnost('" + txt_ukupno_vreme.Text + "', '" + txt_efektivno_vreme.Text + "')");
                komanda = new SqlCommand("SELECT dbo.efikasnost('" + txt_ukupno_vreme.Text + "', '" + txt_efektivno_vreme.Text + "')", veza);           
                txt_efikasnost.Text = komanda.ExecuteScalar().ToString() + "%";
            }
            else
            {
                komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) FROM Pomocna_tabela WHERE datum >= '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "' AND datum <= '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "';", veza);
                txt_ukupno_vreme.Text = komanda.ExecuteScalar().ToString();
                komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) FROM Pomocna_tabela WHERE datum >= '" + datum_pocetka.Value.ToString("yyyy-MM-dd") + "' AND datum <= '" + datum_zavrsetka.Value.ToString("yyyy-MM-dd") + "';", veza);
                txt_efektivno_vreme.Text = komanda.ExecuteScalar().ToString();
                //MessageBox.Show("SELECT dbo.efikasnost('" + txt_ukupno_vreme.Text + "', '" + txt_efektivno_vreme.Text + "')");
                komanda = new SqlCommand("SELECT dbo.efikasnost('" + txt_ukupno_vreme.Text + "', '" + txt_efektivno_vreme.Text + "')", veza);
                txt_efikasnost.Text = komanda.ExecuteScalar().ToString() + "%";

                komanda = new SqlCommand("DROP TABLE Pomocna_tabela", veza);
                komanda.ExecuteNonQuery();
            }            
            veza.Close();
        }

        private void Statistika_sesije_Load(object sender, EventArgs e)
        {            
            veza = new SqlConnection(CS);

            mesta.Columns.Add("ID", typeof(int));
            mesta.Columns.Add("Назив места", typeof(string));
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, naziv AS 'Назив места' FROM Mesto", veza);
            mesta.Rows.Add(0, "Сва места");
            adapter.Fill(mesta);
            cmb_mesto.DataSource = mesta;
            cmb_mesto.ValueMember = "ID";
            cmb_mesto.DisplayMember = "Назив места";

            predmeti.Columns.Add("ID", typeof(int));
            predmeti.Columns.Add("Назив предмета", typeof(string));
            adapter = new SqlDataAdapter("SELECT id AS ID, naziv AS 'Назив предмета' FROM Predmet", veza);
            predmeti.Rows.Add(0, "Сви предмети");
            adapter.Fill(predmeti);
            cmb_predmet.DataSource = predmeti;
            cmb_predmet.ValueMember = "ID";
            cmb_predmet.DisplayMember = "Назив предмета";                                  

            datum_pocetka.Value = DateTime.Now.AddDays(-6);
            datum_zavrsetka.Value = DateTime.Now;

            cmb_predmet.SelectedIndex = 0;
            cmb_mesto.SelectedIndex = 0;

            Osvezi();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void cmb_predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void datum_pocetka_ValueChanged(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void datum_zavrsetka_ValueChanged(object sender, EventArgs e)
        {
            Osvezi();
        }              
    }
}
