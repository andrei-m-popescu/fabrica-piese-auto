using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPiese_PAW_Proiect
{
    internal class LotProdus : ICloneable, IExpirabil
    {
        private string numarLot;
        private DateTime dataProductie;
        private float cantitate;
        private Produs produs;

        public string NumarLot { get => numarLot; set => numarLot = value; }
        public DateTime DataProductie { get => dataProductie; set => dataProductie = value; }
        public float Cantitate { get => cantitate; set => cantitate = value; }
        public Produs Produs { get => produs; set => produs = value; }

        public LotProdus(string numarLot, DateTime dataProd, float cantitate, Produs produs)
        {
            this.numarLot = numarLot;
            this.dataProductie = dataProd;
            this.cantitate = cantitate;
            this.produs = produs;
        }

        public object Clone()
        {
            return new LotProdus(numarLot, dataProductie, cantitate, (Produs)produs.Clone());
        }

        public static LotProdus operator --(LotProdus l)
        {
            l.cantitate -= 1;
            return l;
        }

        public static explicit operator string(LotProdus l)
        {
            return $"{l.numarLot} - {l.produs.Nume} ({l.cantitate} KG)";
        }

        public bool EsteExpirat()
        {
            return cantitate == 0;
        }

        public int ZileRamase()
        {
            return (int)cantitate;
        }
    }
}

