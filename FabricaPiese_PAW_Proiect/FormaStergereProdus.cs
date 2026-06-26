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
    public partial class FormaStergereProdus : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaStergereProdus()
        {
            InitializeComponent();
        }

        private void btn_sterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb_idprodus.Text, out int id))
                    throw new Exception("ID invalid!");

                string query = "delete from Produse where idProdus = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                if (rows == 0) MessageBox.Show("Produsul nu a fost gasit.");
                else MessageBox.Show($"Am sters produsul cu id {id}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_idprodus.Clear();
            }
        }
    }
}

