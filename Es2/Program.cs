using System;
using System.IO;
namespace Es2
{
    class Program
    {
        const int DIMENSIONE = 10;
        static void Main(string[] args)
        {
            string file = "sequenzaNinteripos.txt";
            if (File.Exists(file))
            {
                int c = 0;
                Scrivi(file);
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;

                    Console.WriteLine("Contatore: \nInserire un numero: ");
                    string num = Console.ReadLine();
                    Console.WriteLine("I numeri randomici sono: ");
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        if (num == line)
                            c++;
                    }
                    Console.WriteLine($"Il numero scelto è presente {c} volte");
                }
            }

        }
        private static void Scrivi(string file)
        {
            file = "sequenzaNinteripos.txt";
            if (File.Exists(file))
            {
                try
                {
                    Random r = new Random();
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        int n;
                        for (int i = 0; i < DIMENSIONE; i++)
                        {
                            n = r.Next(1, 10);
                            sw.WriteLine(n);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


