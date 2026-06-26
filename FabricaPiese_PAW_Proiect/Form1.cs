
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaPiese_PAW_Proiect
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bine ati venit la Fabrica de piese auto!");
        }

        // PRODUSE
        private void btnAfiseazaProdus_Click(object sender, EventArgs e)
        {
            FormaAfisareDBProdus form = new FormaAfisareDBProdus();
            form.Show();
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            FormaAdaugareProdus form = new FormaAdaugareProdus();
            form.Show();
        }

        private void btnModificaProdus_Click(object sender, EventArgs e)
        {
            FormaModificareProdus form = new FormaModificareProdus();
            form.Show();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            FormaStergereProdus form = new FormaStergereProdus();
            form.Show();
        }

        // COMENZI
        private void btnAfiseazaComanda_Click(object sender, EventArgs e)
        {
            FormaAfisareDBComanda form = new FormaAfisareDBComanda();
            form.Show();
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            FormaAdaugareComanda form = new FormaAdaugareComanda();
            form.Show();
        }

        private void btnModificaComanda_Click(object sender, EventArgs e)
        {
            FormaModificareComanda form = new FormaModificareComanda();
            form.Show();
        }

        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            FormaStergeComanda form = new FormaStergeComanda();
            form.Show();
        }

        // LOTURI
        private void btnAfiseazaLot_Click(object sender, EventArgs e)
        {
            FormaAfisareDBLot form = new FormaAfisareDBLot();
            form.Show();
        }

        private void btnAdaugaLot_Click(object sender, EventArgs e)
        {
            FormaAdaugareLot form = new FormaAdaugareLot();
            form.Show();
        }

        private void btnModificaLot_Click(object sender, EventArgs e)
        {
            FormaModificareLot form = new FormaModificareLot();
            form.Show();
        }

        private void btnStergeLot_Click(object sender, EventArgs e)
        {
            FormaStergereLot form = new FormaStergereLot();
            form.Show();
        }

        // SAVE TO FILE
        private void saveProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(
                        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT CodProdus, NumeProdus, TipProdus, Greutate FROM Produse", conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            while (reader.Read())
                            {
                                sw.WriteLine($"{reader["CodProdus"]};{reader["NumeProdus"]};{reader["TipProdus"]};{reader["Greutate"]}");
                            }
                        }
                        reader.Close();
                        MessageBox.Show("Produsele au fost salvate in fisier!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(
                        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT NumarComanda, DataComanda, NumeClient, IdProdus, Cantitate FROM Comenzi", conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            while (reader.Read())
                            {
                                sw.WriteLine($"{reader["NumarComanda"]};{reader["DataComanda"]};{reader["NumeClient"]};{reader["IdProdus"]};{reader["Cantitate"]}");
                            }
                        }
                        reader.Close();
                        MessageBox.Show("Comenzile au fost salvate in fisier!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveLoturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(
                        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT NumarLot, DataProductie, Cantitate, IdProdus FROM Loturi", conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            while (reader.Read())
                            {
                                sw.WriteLine($"{reader["NumarLot"]};{reader["DataProductie"]};{reader["Cantitate"]};{reader["IdProdus"]}");
                            }
                        }
                        reader.Close();
                        MessageBox.Show("Loturile au fost salvate in fisier!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            float y = 100;

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT CodProdus, NumeProdus, TipProdus, Greutate FROM Produse", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string linie = $"Cod: {reader["CodProdus"]} | Nume: {reader["NumeProdus"]} | Tip: {reader["TipProdus"]} | Greutate: {reader["Greutate"]} kg";
                    e.Graphics.DrawString(linie, font, System.Drawing.Brushes.Black, 100, y);
                    y += 25;
                }
                reader.Close();

                SqlCommand cmd2 = new SqlCommand("SELECT NumarComanda, DataComanda, NumeClient, Cantitate FROM Comenzi", conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string linie = $"Comanda: {reader2["NumarComanda"]} | Client: {reader2["NumeClient"]} | Data: {reader2["DataComanda"]} | Cantitate: {reader2["Cantitate"]}";
                    e.Graphics.DrawString(linie, font, System.Drawing.Brushes.Black, 100, y);
                    y += 25;
                }
                reader2.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT NumarLot, DataProductie, Cantitate, IdProdus FROM Loturi", conn);
                SqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string linie = $"Lot: {reader3["NumarLot"]} | Data: {reader3["DataProductie"]} | Cantitate: {reader3["Cantitate"]} | ID Produs: {reader3["IdProdus"]}";
                    e.Graphics.DrawString(linie, font, System.Drawing.Brushes.Black, 100, y);
                    y += 25;
                }
                reader3.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += printDocument1_PrintPage;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDoc;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}