using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alle variable
            int i;
            int sum1 = 55;
            int sum2 = 110;
            int sum3 = 165;
            int sum4 = 220;
            int sum5 = 275;
            int sum6 = 330;
            int sum7 = 385;
            int sum8 = 440;
            int sum9 = 495;
            int sum10 = 550;

            


            
            string tabel;
            double tabel1;
            // Forespørgelse af hvilken tabel der ønskes
           




            
            int spørg = 1;

            while (spørg <= 5) { 

            Console.WriteLine("Hvilken tabel ønskes?");
            tabel = Console.ReadLine();
            tabel1 = float.Parse(tabel);

                if (tabel1 < 1 || tabel1 > 10)
                {
                    Console.WriteLine("Du kan kun vælge mellen 1-10 tabellen");
                }


// Switch
            switch (tabel)
            {
                case "1": // Et-Tabel
                    for (i = 1; i >= 1 && i <= 10; i += 1)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i et-tabellen er: {0}", sum1);
                    break;

                case "2": // To-Tabel
                    for (i = 2; i >= 2 && i <= 20; i += 2)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i to-tabellen er: {0}", sum2);
                    break;
                case "3": // Tre-Tabel
                    for (i = 3; i >= 3 && i <= 30; i += 3)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i tre-tabellen er: {0}", sum3);
                    break;
                case "4": // Fire-Tabel
                    for (i = 4; i >= 4 && i <= 40; i += 4)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i fire-tabellen er: {0}", sum4);
                    break;
                case "5": // Fem-Tabel
                    for (i = 5; i >= 5 && i <= 50; i += 5)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i fem-tabellen er: {0}", sum5);
                    break;
                case "6": // Seks-Tabel
                    for (i = 6; i >= 6 && i <= 60; i += 6)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i seks-tabellen er: {0}", sum6);
                    break;
                case "7": // Syv-Tabel
                    for (i = 7; i >= 7 && i <= 70; i += 7)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i syv-tabellen er: {0}", sum7);
                    break;
                case "8": // Otte-Tabel
                    for (i = 8; i >= 8 && i <= 80; i += 8)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i otte-tabellen er: {0}", sum8);
                    break;
                case "9": // Ni-Tabel
                    for (i = 9; i >= 9 && i <= 90; i += 9)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i ni-tabellen er: {0}", sum9);
                    break;
                case "10": // Ti-Tabel
                    for (i = 10; i >= 10 && i <= 100; i += 10)
                    {
                        Console.WriteLine("{0}", i);

                    }
                    Console.WriteLine("Summen af alle tal i ti-tabellen er: {0}", sum10);
                    break;
                }

                spørg++;
            }

        }
    }
}
