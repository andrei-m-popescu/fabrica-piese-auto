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
    public partial class FormaStergeComanda : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaStergeComanda()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb_idComanda.Text, out int id))
                    throw new Exception("ID invalid!");

                string query = "DELETE FROM Comenzi WHERE IdComanda = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                if (rows == 0) MessageBox.Show("Comanda nu a fost gasita.");
                else MessageBox.Show($"Comanda cu id {id} a fost stearsa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_idComanda.Clear();
            }
        }
    }
}