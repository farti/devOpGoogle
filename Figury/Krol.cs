using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy.Figury
{
    class Krol : Figura   
    {
        // pola
        public string NazwaFigury = "Król";

        // metoda spradzająca możliwość ruchu

        public override bool CzyMozeRuszyc (Szachownica NastepnaPozycja )
        {
            if (NastepnaPozycja.WspolrzednaX < 1 || NastepnaPozycja.WspolrzednaX > 8 || NastepnaPozycja.WspolrzednaY < 1 || NastepnaPozycja.WspolrzednaX > 8)
                return false;
            else
            {
                if (Math.Abs(NastepnaPozycja.WspolrzednaX - AktualnaPozycja.WspolrzednaX) > 1 || Math.Abs(NastepnaPozycja.WspolrzednaY - AktualnaPozycja.WspolrzednaY) > 1)
                    return false;
                else
                    return true;
            }
        }

    }
}
