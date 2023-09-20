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

        public Statistika_sesije()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            tabela.Clear();
            veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + " +
                "CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme)))) AS " +
                "VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', " +
                "CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE " +
                "datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;", veza);
            adapter.Fill(tabela);
            grafikon.DataSource = tabela;    
            grafikon.DataBind();                     
            SqlCommand komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);
            veza.Open();
            txt_ukupno_vreme.Text = komanda.ExecuteScalar().ToString();
            komanda = new SqlCommand("SELECT dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);
            txt_efektivno_vreme.Text = komanda.ExecuteScalar().ToString();
            komanda = new SqlCommand("SELECT dbo.efikasnost_sesije(CAST('" + txt_ukupno_vreme.Text + "' AS TIME), CAST('" + txt_efektivno_vreme.Text + "' AS TIME))", veza);
            txt_efikasnost.Text = komanda.ExecuteScalar().ToString() + "%";
            veza.Close();
        }

        private void Statistika_sesije_Load(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }
    }
}
