using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaPiese_PAW_Proiect
{
    public partial class UserControlJudet : UserControl
    {
        public UserControlJudet()
        {
            InitializeComponent();
        }

        public Judet SelectedJudet
        {
            get { return (Judet)cbJudet.SelectedItem; }
        }
        private void UserControlJudet_Load(object sender, EventArgs e)
        {
            List<Judet> judete = new List<Judet>
            {
                new Judet { ID = 1, Nume = "Bucuresti" },
                new Judet { ID = 2, Nume = "Ilfov" },
                new Judet { ID = 3, Nume = "Cluj" },
                new Judet { ID = 4, Nume = "Timis" },
                new Judet { ID = 5, Nume = "Iasi" }
            };

            cbJudet.DataSource = judete;
            cbJudet.ValueMember = "ID";
            cbJudet.DisplayMember = "Nume";
        }
    }
}
