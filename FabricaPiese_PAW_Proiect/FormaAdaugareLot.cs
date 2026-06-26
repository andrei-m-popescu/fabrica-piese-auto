using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaPiese_PAW_Proiect
{
    public partial class FormaAdaugareLot : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaAdaugareLot()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_numarLot.Text.Length == 0)
                    throw new Exception("Numar lot invalid!");

                if (!DateTime.TryParse(tb_dataProductie.Text, out DateTime dataProductie))
                    throw new Exception("Data productie invalida!");

                if (!float.TryParse(tb_cantitate.Text, out float cantitate))
                    throw new Exception("Cantitate invalida!");

                if (!int.TryParse(tb_idProdus.Text, out int idProdus))
                    throw new Exception("ID Produs invalid!");

                string query = "INSERT INTO Loturi (NumarLot, DataProductie, Cantitate, IdProdus) VALUES (@numarLot, @dataProductie, @cantitate, @idProdus)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@numarLot", tb_numarLot.Text);
                cmd.Parameters.AddWithValue("@dataProductie", dataProductie);
                cmd.Parameters.AddWithValue("@cantitate", cantitate);
                cmd.Parameters.AddWithValue("@idProdus", idProdus);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lotul a fost adaugat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_numarLot.Clear();
                tb_dataProductie.Clear();
                tb_cantitate.Clear();
                tb_idProdus.Clear();
            }
        }
    }
}