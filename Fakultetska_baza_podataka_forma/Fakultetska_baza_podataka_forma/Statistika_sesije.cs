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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT CONVERT(VARCHAR, datum, 104) + CHAR(13) + CHAR(10) + CAST(dbo.efikasnost_sesije(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))), dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme)))) AS VARCHAR) + '%' AS 'Датум и ефикасност', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(ukupno_vreme))) AS VARCHAR(5)) AS 'Укупно време', CAST(dbo.minuti_u_sate(SUM(dbo.sati_u_minute(efektivno_vreme))) AS VARCHAR(5)) AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -8, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE) GROUP BY datum;", veza);
            adapter.Fill(tabela);
            grafikon.DataSource = tabela;    
            grafikon.DataBind();                     
            //SqlCommand komanda = new SqlCommand("SELECT SUM(dbo.sati_u_minute(ukupno_vreme)) / 60.0 AS 'Укупно време', SUM(dbo.sati_u_minute(efektivno_vreme)) / 60.0 AS 'Ефективно време' FROM Sesija WHERE datum >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE)) AND datum <= CAST(GETDATE() AS DATE);", veza);            
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
