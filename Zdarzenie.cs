using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMR
{
    class Zdarzenie
    {
        public static void write(string message)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss : " + message));
        }
    }
}
