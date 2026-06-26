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
    public partial class FormaAdaugareComanda : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaAdaugareComanda()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_numarComanda.Text.Length == 0 || tb_numeClient.Text.Length == 0)
                    throw new Exception("Numar comanda / Nume client invalid!");

                if (!int.TryParse(tb_idProdus.Text, out int idProdus))
                    throw new Exception("ID Produs invalid!");

                if (!float.TryParse(tb_cantitate.Text, out float cantitate))
                    throw new Exception("Cantitate invalida!");

                string query = "INSERT INTO Comenzi (NumarComanda, DataComanda, NumeClient, IdProdus, Cantitate) VALUES (@numar, @data, @client, @idProdus, @cantitate)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@numar", tb_numarComanda.Text);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);
                cmd.Parameters.AddWithValue("@client", tb_numeClient.Text);
                cmd.Parameters.AddWithValue("@idProdus", idProdus);
                cmd.Parameters.AddWithValue("@cantitate", cantitate);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comanda a fost adaugata!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_numarComanda.Clear();
                tb_numeClient.Clear();
                tb_idProdus.Clear();
                tb_cantitate.Clear();
            }
        }
    }
}
