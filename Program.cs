using System;
using System.Diagnostics;
namespace LA1001_1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int num = -1;
            int i = 0;
            int RNG = 0;
            int g = 0;
            
            Stopwatch sw = new Stopwatch();
           


                if (Console.BackgroundColor == ConsoleColor.Black)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                }
                Console.WriteLine("In welchem Zahlenbereich wollen sie Raten");
                string s = Console.ReadLine();

                while (!int.TryParse(s, out num))
                {
                    try
                    {
                        Console.WriteLine("Geben Sie eine Zahl ein: ");
                        s = Console.ReadLine();
                        i = Convert.ToInt32(s);
                    }
                    catch
                    {
                        continue;
                    }

                }
                if (int.TryParse(s, out num))
                {
                    i = Convert.ToInt32(s);
                }




                Random rnd = new Random();
                sw.Start();
                Console.Write("Schreiben Sie eine Zahl zwischen 1 und {0}: ", i);
                string Eingabe = Console.ReadLine();


                int Zahleneingabe = 0;
                RNG = rnd.Next(1, i);






                while (!int.TryParse(Eingabe, out num))
                {
                    try
                    {
                        Console.WriteLine("Geben Sie eine Zahl ein: ");
                        Eingabe = Console.ReadLine();
                        Zahleneingabe = Convert.ToInt32(Eingabe);
                    }
                    catch
                    {
                        continue;
                    }


                }
                if (int.TryParse(Eingabe, out num))
                {
                    Zahleneingabe = Convert.ToInt32(Eingabe);
                }


                while (Zahleneingabe > i || Zahleneingabe < 1)
                {
                    try
                    {
                        Console.Write("Geben Sie einen Zahl ein: ");
                        Zahleneingabe = Convert.ToInt32(Console.ReadLine());
                        if (Zahleneingabe > i || Zahleneingabe < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        continue;
                    }


                }

                while (Zahleneingabe <= i && Zahleneingabe >= 1)
                {


                    while (RNG != Zahleneingabe)
                    {



                        if (RNG > Zahleneingabe && Zahleneingabe <= i && Zahleneingabe >= 1)
                        {
                            Console.WriteLine("Ihre Zahl ist zu klein.");
                        }


                        else if (RNG < Zahleneingabe && Zahleneingabe <= i && Zahleneingabe >= 1)
                        {
                            Console.WriteLine("Ihre Zahl ist zu gross.");
                        }


                        if (Zahleneingabe > i || Zahleneingabe < 1)
                        {
                            Console.Write("Geben Sie eine Zahl ein: ");
                        }
                        Eingabe = Console.ReadLine();
                        while (!int.TryParse(Eingabe, out num))
                        {
                            try
                            {
                                Console.Write("Geben Sie eine Zahl ein: ");
                                Eingabe = Console.ReadLine();
                                Zahleneingabe = Convert.ToInt32(Eingabe);
                            }
                            catch
                            {
                                continue;
                            }


                        }
                        if (int.TryParse(Eingabe, out num))
                        {
                            Zahleneingabe = Convert.ToInt32(Eingabe);
                        }
                        g++;

                    }

                    Console.Clear();
                    Console.WriteLine("Ihre Zahl ist Richtig.");
                    Console.WriteLine("Sie haben {0} Versuche gebraucht", g);
                    Console.WriteLine("Sie haben {0:ss} sekunden gebraucht", sw.Elapsed);
                  
                    string yesNo = "";


                    
                    
                        Console.WriteLine("Wollen Sie weiterspielen[ja/nein]? ");
                    sw.Stop();
                    
                yesNo = Console.ReadLine();
                        if (yesNo == "ja")
                        {
                            sw.Restart();
                            Zahleneingabe = 0;
                            i = 0;
                            s = "";
                            Console.WriteLine("In welchem Zahlenbereich wollen sie Raten");

                            while (!int.TryParse(s, out num))
                            {
                                try
                                {
                                    Console.WriteLine("Geben Sie eine Zahl ein: ");
                                    s = Console.ReadLine();
                                    i = Convert.ToInt32(s);

                                }
                                catch
                                {
                                    continue;
                                }

                            }
                            if (int.TryParse(s, out num))
                            {
                                i = Convert.ToInt32(s);
                            }

                            Console.Write("Schreiben Sie eine Zahl zwischen 1 und {0}: ", i);
                            Eingabe = Console.ReadLine();
                            while (!int.TryParse(Eingabe, out num))
                            {
                                try
                                {
                                    Console.WriteLine("Geben Sie eine Zahl ein: ");
                                    Eingabe = Console.ReadLine();
                                    Zahleneingabe = Convert.ToInt32(Eingabe);
                                }
                                catch
                                {
                                    continue;
                                }


                            }
                            if (int.TryParse(Eingabe, out num))
                            {
                                Zahleneingabe = Convert.ToInt32(Eingabe);
                            }

                            RNG = 0;
                            RNG = rnd.Next(1, i);

                            continue;
                        }
                        else if(yesNo == "nein")
                        {
                            break;
                        }

                }
        }
        
    }
}