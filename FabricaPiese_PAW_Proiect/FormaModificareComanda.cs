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
    public partial class FormaModificareComanda : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaModificareComanda()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb_idComanda.Text, out int id))
                    throw new Exception("ID invalid!");

                if (tb_numeClient.Text.Length == 0)
                    throw new Exception("Nume client invalid!");

                string query = "UPDATE Comenzi SET NumeClient = @numeClient WHERE IdComanda = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@numeClient", tb_numeClient.Text);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                if (rows == 0) MessageBox.Show("Comanda nu a fost gasita.");
                else MessageBox.Show("Comanda a fost modificata!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_idComanda.Clear();
                tb_numeClient.Clear();
            }
        }
    }
}
