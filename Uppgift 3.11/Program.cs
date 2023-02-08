using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en frågekategori. ");
            Console.WriteLine("1. Musik ");
            Console.WriteLine("2. Geografi");
            Console.WriteLine("3. Historia");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine("Vilken artist skrev låten \"Reaktorn läck i barsebäck\" ?");
                    string svar1 = Console.ReadLine();
                    string svar1LC = svar1.ToLower();

                    if (svar1LC == "eddie meduza")
                    {
                        Console.WriteLine("RÄTT");
                    }

                    else
                    {
                        Console.WriteLine("FEL");
                    }
                    break;


                case "2":
                    Console.WriteLine("Vilket land kommer Melker ifrån?");
                    string svar2 = Console.ReadLine();
                    string svar2LC = svar2.ToLower();

                    if (svar2LC == "thailand")
                    {
                        Console.WriteLine("RÄTT");
                    }

                    else
                    {
                        Console.WriteLine("FEL");
                    }
                    break;

                case "3":
                    Console.WriteLine("När föddes Sveriges nuvarande kung?");
                    string svar3 = Console.ReadLine();

                    if (svar3 == "1946")
                    {
                        Console.WriteLine("RÄTT");
                    }

                    else
                    {
                        Console.WriteLine("FEL");
                    }
                    break;

                default:
                    Console.WriteLine("DU SKULLE VÄLJA ETT AV ALTERNATIVEN!!!");
                    break;
                    


            }

        }
    }
}
