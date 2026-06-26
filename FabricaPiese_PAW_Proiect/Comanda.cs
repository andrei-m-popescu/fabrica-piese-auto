using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPiese_PAW_Proiect
{
    public class Comanda : ICloneable
    {
        public int IdComanda { get; set; }
        public string NumarComanda { get; set; }
        public DateTime DataComanda { get; set; }
        public string NumeClient { get; set; }
        public int IdProdus { get; set; }
        public float Cantitate { get; set; }

        public Comanda(int id, string numar, DateTime data, string client, int idProdus, float cantitate)
        {
            IdComanda = id;
            NumarComanda = numar;
            DataComanda = data;
            NumeClient = client;
            IdProdus = idProdus;
            Cantitate = cantitate;
        }

        public object Clone()
        {
            return new Comanda(IdComanda, NumarComanda, DataComanda, NumeClient, IdProdus, Cantitate);
        }

        public override string ToString()
        {
            return $"Comanda {NumarComanda} - Client: {NumeClient}, Data: {DataComanda.ToShortDateString()}";
        }
    }
}
