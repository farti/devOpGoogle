using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachy.Figury;
using Szachy;

namespace Szachy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj pozycję początkową , np. B4  : ");
            string wyborPozycji = Console.ReadLine();
            Console.Write("Podaj kolor (c - czarne , b - białe) : ");
            string wyburKoloru = Console.ReadLine();

            Console.WriteLine("Wybierz figurę :");
            Console.WriteLine("   1. Król.");
            Console.WriteLine("   2. Goniec.");
            Console.WriteLine("   3. Wieża.");
            Console.WriteLine("   4. Pionek.");

            string  wyborFigury = Console.ReadLine();

            switch(wyborFigury )
            {
                case "1":
                    
                    Krol krol = new Krol();
                    krol.PoczatkowaPozycja( new Szachownica(wyborPozycji) );
                    krol.WybranyKolor(wyburKoloru);
                    Console.WriteLine("Twoja figura to: "+ krol.NazwaFigury + ", kolor : "+ krol.WybranyKolor(wyburKoloru) + " , na pozycji : "+ wyborPozycji );
                    Console.Write("Podaj pozycję docelową : ");
                    string nowaPozycja = Console.ReadLine();
                    Szachownica docelowaPozycja = new Szachownica(nowaPozycja );
                    if (krol.CzyMozeRuszyc(docelowaPozycja))
                        {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja + "  jest OK");
                        }
                    else
                        {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja + "  jest ZABRONIONY");
                        }
                    break;

                case "2":

                    Goniec  goniec = new Goniec();
                    goniec .PoczatkowaPozycja(new Szachownica(wyborPozycji));
                    goniec .WybranyKolor(wyburKoloru);
                    Console.WriteLine("Twoja figura to: " + goniec .NazwaFigury + ", kolor : " + goniec.WybranyKolor(wyburKoloru) + " , na pozycji : " + wyborPozycji);
                    Console.Write("Podaj pozycję docelową : ");
                    string nowaPozycja1 = Console.ReadLine();
                    Szachownica docelowaPozycja1 = new Szachownica(nowaPozycja1);
                    if (goniec.CzyMozeRuszyc(docelowaPozycja1))
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja1 + "  jest OK");
                    }
                    else
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja1 + "  jest ZABRONIONY");
                    }
                    break;

                case "3":
                    Wieza  wieza = new Figury.Wieza ();
                    wieza.PoczatkowaPozycja(new Szachownica(wyborPozycji));
                    wieza.WybranyKolor(wyburKoloru);
                    Console.WriteLine("Twoja figura to: " + wieza.NazwaFigury + ", kolor : " + wieza.WybranyKolor(wyburKoloru) + " , na pozycji : " + wyborPozycji);
                    Console.Write("Podaj pozycję docelową : ");
                    string nowaPozycja2 = Console.ReadLine();
                    Szachownica docelowaPozycja2 = new Szachownica(nowaPozycja2);
                    if (wieza.CzyMozeRuszyc(docelowaPozycja2))
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja2 + "  jest OK");
                    }
                    else
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja2 + "  jest ZABRONIONY");
                    }
                    break;
                case "4":
                    Pionek pionek = new Pionek ();
                    pionek .PoczatkowaPozycja(new Szachownica(wyborPozycji));
                    pionek .WybranyKolor(wyburKoloru);
                    Console.WriteLine("Twoja figura to: " + pionek .NazwaFigury + ", kolor : " + pionek.WybranyKolor(wyburKoloru) + " , na pozycji : " + wyborPozycji);
                    Console.Write("Podaj pozycję docelową : ");
                    string nowaPozycja3 = Console.ReadLine();
                    Szachownica docelowaPozycja3 = new Szachownica(nowaPozycja3);
                    if (pionek.CzyMozeRuszyc(docelowaPozycja3))
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja3 + "  jest OK");
                    }
                    else
                    {
                        Console.WriteLine("Ruch z: " + wyborPozycji + " na " + nowaPozycja3 + "  jest ZABRONIONY");
                    }
                    break;

                default:
                    Console.WriteLine("Zły wybór !");
                    break;
                      
            }











            Console.Read();

               
        }
    }
}
