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
    public partial class FormaStergereLot : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaStergereLot()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_numarLot.Text.Length == 0)
                    throw new Exception("Numar lot invalid!");

                string query = "DELETE FROM Loturi WHERE NumarLot = @numarLot";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@numarLot", tb_numarLot.Text);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                if (rows == 0) MessageBox.Show("Lotul nu a fost gasit.");
                else MessageBox.Show($"Lotul {tb_numarLot.Text} a fost sters!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_numarLot.Clear();
            }
        }
    }
}