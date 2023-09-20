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

        public Statistika_sesije()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            tabela.Clear();            
            SqlDataAdapter adapter;            
            veza = new SqlConnection(CS);
            veza.Open();
            SqlCommand komanda = new SqlCommand("SELECT id FROM Predmet WHERE naziv = N'Непознато'", veza);
            if (cmb_predmet.SelectedValue == komanda.ExecuteScalar())
            {
                MessageBox.Show("Usao");
                adapter = new SqlDataAdapter("SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + " +
                "CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme)))) AS " +
                "VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', " +
                "CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE " +
                "datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;", veza);
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + " +
                "CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme)))) AS " +
                "VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', " +
                "CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE " +
                "datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) AND (fk_predmet = " + cmb_predmet.SelectedValue + " OR fk_predmet = " + komanda.ExecuteScalar() + ") GROUP BY datum;", veza);
            }
            adapter.Fill(tabela);
            grafikon.DataSource = tabela;    
            grafikon.DataBind();                     
            komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);            
            txt_ukupno_vreme.Text = komanda.ExecuteScalar().ToString();
            komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);
            txt_efektivno_vreme.Text = komanda.ExecuteScalar().ToString();
            komanda = new SqlCommand("SELECT dbo.efikasnost('" + txt_ukupno_vreme.Text + "', '" + txt_efektivno_vreme.Text + "')", veza);
            txt_efikasnost.Text = komanda.ExecuteScalar().ToString() + "%";
            veza.Close();
        }

        private void Statistika_sesije_Load(object sender, EventArgs e)
        {            
            veza = new SqlConnection(CS);
            veza.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Predmet", veza);            
            adapter.Fill(predmeti);
            cmb_predmet.DataSource = predmeti;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            SqlCommand komanda = new SqlCommand("SELECT id FROM Predmet WHERE naziv = N'Непознато'", veza);
            cmb_predmet.SelectedValue = komanda.ExecuteScalar();
            veza.Close();
            Osvezi();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }
    }
}
