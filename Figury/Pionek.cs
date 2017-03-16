using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy.Figury
{
    class Pionek: Figura
    {
        // pola
        public string NazwaFigury = "Pionek";

        // metoda spradzająca możliwość ruchu

        public bool CzyMozeRuszyc(Szachownica NastepnaPozycja)
        {
            if (NastepnaPozycja.WspolrzednaX < 1 || NastepnaPozycja.WspolrzednaX > 8 || NastepnaPozycja.WspolrzednaY < 1 || NastepnaPozycja.WspolrzednaX > 8)
                return false;
            else
            {
                if (Math.Abs(NastepnaPozycja.WspolrzednaX - AktualnaPozycja.WspolrzednaX) !=0 || Math.Abs(NastepnaPozycja.WspolrzednaY - AktualnaPozycja.WspolrzednaY) > 1)
                    return false;
                else
                    return true;
            }
        }
    }
}
