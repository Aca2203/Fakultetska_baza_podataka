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
            if (cmb_predmet.SelectedIndex == 0)
            {                
                adapter = new SqlDataAdapter("SELECT CONVERT(VARCHAR, Datum.datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Datum LEFT JOIN Sesija ON Datum.datum = Sesija.datum WHERE Datum.datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND Datum.datum <= CAST(GETDATE() AS DATE) GROUP BY Datum.datum;", veza);
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT CONVERT(VARCHAR, Datum.datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(Sesija.efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Datum LEFT JOIN Sesija ON Datum.datum = Sesija.datum WHERE Datum.datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND Datum.datum <= CAST(GETDATE() AS DATE) AND Sesija.fk_predmet = " + cmb_predmet.SelectedValue + " GROUP BY Datum.datum;", veza);
            }
            adapter.Fill(tabela);
            grafikon.DataSource = tabela;    
            grafikon.DataBind();
            veza.Open();
            SqlCommand komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);            
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
            predmeti.Columns.Add("ID", typeof(int));
            predmeti.Columns.Add("Назив предмета", typeof(string));
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, naziv AS 'Назив предмета' FROM Predmet", veza);
            predmeti.Rows.Add(0, "Сви предмети");
            adapter.Fill(predmeti);
            cmb_predmet.DataSource = predmeti;
            cmb_predmet.ValueMember = "ID";
            cmb_predmet.DisplayMember = "Назив предмета";           
            cmb_predmet.SelectedIndex = 0;
            veza.Close();
            Osvezi();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }
    }
}
