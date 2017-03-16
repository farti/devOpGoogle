using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    /// <summary>
    /// ustala pozycję figury na szachownicy
    /// </summary>
    class Szachownica 
    {
        // pola
        private int _wpolrzednaX;   // współrzędna pozioma od literek
        private int _wspolrzednaY;   // współrzędna pionowa od cyferek
        private string _pozycja;
        // properties
        public int WspolrzednaX
        {
            get { return _wpolrzednaX; }
            set { _wpolrzednaX = value; }
        }
        public int WspolrzednaY
        {
            get { return _wspolrzednaY ; }
            set { _wspolrzednaY  = value; }
        }

        public string Pozycja
        {
            get { return _pozycja; }
            set { _pozycja = value; }
        }
        // metoda Szachownica odczytuje string na współrzędne x i y
        public Szachownica ( string Pozycja)
        {
            WspolrzednaX  = Encoding.ASCII.GetBytes(Pozycja )[0] - 64;
            WspolrzednaY  = Encoding.ASCII.GetBytes(Pozycja )[1] - 48;
        }
    }
}
