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
    public partial class Datumi : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
        DataTable podaci = new DataTable();
        SqlConnection veza;

        public Datumi()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            podaci.Clear();
            veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT datum AS 'Датум' FROM Datum ORDER BY datum DESC", veza);
            adapter.Fill(podaci);
            grid_podaci.DataSource = podaci;            
        }

        private void Datumi_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn kolona in grid_podaci.Columns)
            {
                kolona.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Osvezi();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                veza = new SqlConnection(CS);
                veza.Open();
                SqlCommand komanda;                

                for (DateTime datum = datum_pocetka.Value; datum <= datum_zavrsetka.Value; datum = datum.AddDays(1))
                {
                    komanda = new SqlCommand("Datum_Insert", veza);
                    komanda.CommandType = CommandType.StoredProcedure;
                    komanda.Parameters.AddWithValue("@datum", SqlDbType.Date).Value = datum;

                    var povratni_parametar = komanda.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    povratni_parametar.Direction = ParameterDirection.ReturnValue;

                    komanda.ExecuteNonQuery();
                    int povratna_vrednost = (int)povratni_parametar.Value;
                    if (povratna_vrednost != 0)
                    {
                        if (povratna_vrednost == -1) MessageBox.Show("Датум " + datum.ToString("dd.MM.yyyy") + " већ постоји!");
                        else MessageBox.Show("Дошло је до грешке: " + povratna_vrednost);
                        break;
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
