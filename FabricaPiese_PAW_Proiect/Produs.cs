using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPiese_PAW_Proiect
{
    public enum TipProdus
    {
        Motor,
        Caroserie,
        Electric,
        Transmisie
    }

    internal class Produs : ICloneable, IComparable<Produs>
    {
        private int id;
        private string cod;
        private string nume;
        private TipProdus tip;
        private float greutate;

        public int Id { get => id; set => id = value; }
        public string Cod { get => cod; set => cod = value; }
        public string Nume { get => nume; set => nume = value; }
        public TipProdus Tip { get => tip; set => tip = value; }
        public float Greutate { get => greutate; set => greutate = value; }

        public Produs(int id, string cod, string nume, TipProdus tip, float greutate)
        {
            this.id = id;
            this.cod = cod;
            this.nume = nume;
            this.tip = tip;
            this.greutate = greutate;
        }

        public object Clone()
        {
            return new Produs(id, cod, nume, tip, greutate);
        }

        public int CompareTo(Produs other)
        {
            return this.greutate.CompareTo(other.greutate);
        }

        public static bool operator >(Produs p1, Produs p2)
        {
            return p1.greutate > p2.greutate;
        }

        public static bool operator <(Produs p1, Produs p2)
        {
            return p1.greutate < p2.greutate;
        }

        public static Produs operator ++(Produs p)
        {
            p.greutate += 10;
            return p;
        }

        public override string ToString()
        {
            return $"Produs: {nume} | Cod: {cod} | Tip: {tip} | Greutate: {greutate} kg";
        }
    }
}
