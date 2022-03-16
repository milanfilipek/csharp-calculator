using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kalkulacka - zadani dvou cisel a nasledny vyber operace (+,-,*,/), po dokonceni se zepta uzivatele zda-li chce provest dalsi operaci.
            float vysledek = 0.0f;
            string operace;

            while (true) {
                Console.WriteLine("Zadej pozadovanou operaci (+, -, *, /, mocnina, odmocnina, sin, cos, tg, cotg): "); // vyzve uzivatele k zadani pozadovane operace
                operace = Console.ReadLine();

                if (operace.Contains("mocnina"))
                {
                    if (operace.Equals("mocnina"))
                    {
                        Console.WriteLine("Zadej cislo a exponent: ");
                        float.TryParse(Console.ReadLine(), out float c1);
                        float.TryParse(Console.ReadLine(), out float exponent);

                        vysledek = (float)Math.Pow(c1, exponent);
                    }

                    else if (operace.Equals("odmocnina"))
                    {
                        Console.WriteLine("Zadej cislo a odmocnitele: ");
                        float.TryParse(Console.ReadLine(), out float c1);
                        float.TryParse(Console.ReadLine(), out float odmocnitel);

                        vysledek = (float)Math.Pow(c1, 1 / odmocnitel);
                    }

                    else {
                        Console.WriteLine("Zadali jste spatnou operaci!");
                    }
                }

                else if (operace.Contains("sin") || operace.Contains("cos") || operace.Contains("tg") || operace.Contains("cotg")){
                    Console.WriteLine("Zadej cislo, ze ktereho chces vypocitat hodnotu " + operace);
                    float.TryParse(Console.ReadLine(), out float c1);

                    if (operace.Contains("sin")) vysledek = (float)Math.Sin(c1);
                    else if (operace.Contains("cos")) vysledek = (float)Math.Cos(c1);
                    else if (operace.Contains("tg")) vysledek = (float)Math.Tan(c1);
                    else vysledek = (float)(Math.Cos(c1) / Math.Sin(c1));
                }

                else{
                    Console.WriteLine("Zadej dve cisla:"); // vyzve uzivatele k zadani dvou cisel
                    float.TryParse(Console.ReadLine(), out float c1); // prvni cislo
                    float.TryParse(Console.ReadLine(), out float c2);// druhe cislo

                    if (operace == "/")
                    {
                        if (c2 == 0)
                        { // osetreni pro deleni nulou
                            Console.WriteLine("Nelze dělit nulou.");
                        }
                        else
                        {
                            vysledek = c1 / c2; // deleni dvou cisel
                        }
                    }

                    else if (operace == "+")
                    {
                        vysledek = c1 + c2; // secteni dvou cisel
                    }

                    else if (operace == "-")
                    {
                        vysledek = c1 - c2; // odecteni dvou cisel
                    }

                    else if (operace == "*")
                    {
                        vysledek = c1 * c2;
                    }

                    else
                    {
                        Console.WriteLine("Zadali jste spatnou operaci, prosim vyberte si z jednu podporavnych operaci.\nPodporovanymi operacemi jsou: + (soucet), - (rozdil), * (soucin), / (podil).\nOperace se zadavaji znaky + - * /.");
                    }
                }

                Console.WriteLine("Vysledek: " + vysledek.ToString());

                Console.WriteLine("Chces provest dalsi vypocet? (Zadej 0 pro NE nebo jakekoliv cislo pro ANO)");
                int.TryParse(Console.ReadLine(), out int dalsi);

                if (dalsi == 0)
                {
                    break; // pokud uzivatel nechce provest dalsi vypocet, tak cyklus se prerusi zde a potom vyzada uzivatele o stisknuti ENTERu pro ukonceni programu.
                }
                else {
                    Console.Clear(); // vycisteni obrazovky
                }
            }

            Console.WriteLine("Program ukončíte stisknutím tlačítka ENTER.");
            Console.ReadLine(); //konec programu po stisknuti ENTERu
        }
    }
}
