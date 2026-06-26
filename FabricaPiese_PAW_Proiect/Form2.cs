using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaPiese_PAW_Proiect
{
    public class LotInfo
    {
        public string NumarLot { get; set; }
        public float Cantitate { get; set; }
    }

    public partial class Form2 : Form
    {
        List<LotInfo> listaLoturi = new List<LotInfo>();
        bool dateIncarcate = false;

        public Form2()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UserControlJudet ucJudete = new UserControlJudet();
            this.Controls.Add(ucJudete);
            ucJudete.Location = new Point(20, 20);
        }

        private void btn_incarca_Click(object sender, EventArgs e)
        {
            listaLoturi.Clear();
            using (SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FabricaPieseAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NumarLot, Cantitate FROM Loturi", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaLoturi.Add(new LotInfo
                    {
                        NumarLot = reader["NumarLot"].ToString(),
                        Cantitate = Convert.ToSingle(reader["Cantitate"])
                    });
                }
                dateIncarcate = true;
                panel1.Invalidate();
            }
        }

        const int margine = 10;
        Color culoareBars = Color.Orange;
        Font fontText = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        Color culoareText = Color.Black;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!dateIncarcate || listaLoturi.Count == 0)
                return;

            Graphics g = e.Graphics;
            Rectangle rectangle = new Rectangle(
                panel1.ClientRectangle.X + margine,
                panel1.ClientRectangle.Y + 4 * margine,
                panel1.ClientRectangle.Width - 2 * margine,
                panel1.ClientRectangle.Height - 5 * margine);

            Pen pen = new Pen(Color.Gray, 2);
            g.DrawRectangle(pen, rectangle);

            double latime = rectangle.Width / listaLoturi.Count / 2;
            double distanta = rectangle.Width / listaLoturi.Count;
            float maxVal = listaLoturi.Max(l => l.Cantitate);

            Brush brushBars = new SolidBrush(culoareBars);
            Brush brushFont = new SolidBrush(culoareText);

            for (int i = 0; i < listaLoturi.Count; i++)
            {
                double inaltimeBar = listaLoturi[i].Cantitate / maxVal * rectangle.Height;
                Rectangle bar = new Rectangle(
                    (int)(rectangle.X + i * distanta + latime / 2),
                    (int)(rectangle.Bottom - inaltimeBar),
                    (int)latime,
                    (int)inaltimeBar);

                g.FillRectangle(brushBars, bar);
                g.DrawString(listaLoturi[i].NumarLot, fontText, brushFont,
                    bar.X, bar.Bottom + 2);
            }
        }
    }
}
