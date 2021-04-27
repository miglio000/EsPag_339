using System;
using System.IO;
namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "es4.txt";
            string fileout = "es4out.txt";
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    StreamWriter sw = new StreamWriter(fileout);
                    string linesr;
                    while ((linesr = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(linesr);
                    }
                    sw.Flush();
                }
            }
        }
    }
}
