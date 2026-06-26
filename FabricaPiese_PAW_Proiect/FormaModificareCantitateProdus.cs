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
    public partial class FormaModificareProdus : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaModificareProdus()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_greutate.Text.Length == 0 || tb_codprodus.Text.Length == 0) throw new Exception("Nume invalid!");

                string cod = tb_codprodus.Text;
   
                float greutate = float.Parse(tb_greutate.Text);

                string query = "update produse set greutate = @greutate where codprodus = @cod";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@greutate", greutate);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                if (rows == 0) MessageBox.Show("Produsul nu exista!");
                else MessageBox.Show("Am modificat produsul!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_codprodus.Clear();
                tb_greutate.Clear();   
            }
        }
    }
}
