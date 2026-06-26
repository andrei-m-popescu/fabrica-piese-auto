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
    public partial class FormaAdaugareProdus : Form
    {

        private SqlConnection connection = new SqlConnection(
"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormaAdaugareProdus()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_codProdus.Text.Length == 0 || tb_numeProdus.Text.Length == 0) { throw new Exception("Cod/Nume incorect!"); }

                string cod = tb_codProdus.Text;
                string nume = tb_numeProdus.Text;
                string tipString = cb_tipProdus.Text;
                float greutate = float.Parse(tb_greutate.Text);

                TipProdus tip;
                if (tipString.Equals("Motor"))
                    tip = TipProdus.Motor;
                else if (tipString.Equals("Caroserie"))
                    tip = TipProdus.Caroserie;
                else if (tipString.Equals("Electric"))
                    tip = TipProdus.Electric;
                else if (tipString.Equals("Transmisie"))
                    tip = TipProdus.Transmisie;
                else throw new Exception("Produsul trebuie sa aiba un tip!");

                /*MessageBox.Show($"INSERT: {cod}, {nume}, {tip}, {greutate}");*/
                connection.Open();
                /*MessageBox.Show("Incercam sa adaugam...");*/

                //string query = "insert into Produse (CodProdus, NumeProdus, TipProdus, Greutate) VALUES (" + cod + "," + nume + "," + tip + ", " + greutate + ")";
                string query = "insert into Produse (CodProdus, NumeProdus, TipProdus, Greutate) VALUES (@cod, @nume, @tip, @greutate)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@tip", tip.ToString());
                cmd.Parameters.AddWithValue("@greutate", greutate);

                cmd.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show($"Am adaugat {nume}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                tb_codProdus.Clear();
                tb_numeProdus.Clear();
                tb_greutate.Clear();
                cb_tipProdus.SelectedIndex = -1;
            }
        }
    }
}
