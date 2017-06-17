using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachy;

namespace ChessMR
{
    class Indexer
    {
        public Figura[,] Figures = new Figura[8, 8];
        public Figura this[string wyborpozycji]
        {
            get
            {
                int x = Encoding.ASCII.GetBytes(wyborpozycji)[0] - 64;
                int y = Encoding.ASCII.GetBytes(wyborpozycji)[1] - 48;

                return this.Figures[x, y];
            }

            set
            {
                int x = Encoding.ASCII.GetBytes(wyborpozycji)[0] - 64;
                int y = Encoding.ASCII.GetBytes(wyborpozycji)[1] - 48;

                this.Figures[x, y] = value;
            }


        }
    }

}
