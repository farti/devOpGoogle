using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    /// <summary>
    /// Nadrzędna klasa abstrakcyjna określająca kolor i pozycję figury
    /// </summary>
    abstract class Figura
    {
        // pola
        private string _kolor;

        // propoerties
        public string Kolor
        {
            get { return _kolor; }
            set { _kolor = value; }
        }
        public Szachownica AktualnaPozycja;


        // Metody

        public string WybranyKolor(string Kolor)
        {
            if (Kolor == "c") return (Kolor = "czarny");
            else
                return (Kolor = "biały");
        }

        public void PoczatkowaPozycja(Szachownica pozycja)
        {
            this.AktualnaPozycja = pozycja;
        }

        public abstract bool CzyMozeRuszyc(Szachownica NastepnaPozycja);


    }
}
