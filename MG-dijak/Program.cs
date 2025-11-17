using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_dijak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
           MG-díjak
           MG 2025.11.17.
           */
            string fejlec = "Baseball díjak 2007 - 2010";
            Console.WriteLine(fejlec);

            for (int i = 0; i < fejlec.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            List<List<string>> dijak = new List<List<string>>();
            
            StreamReader sr = new StreamReader("../../dijak.csv", Encoding.UTF8);

            string[] asd = sr.ReadLine().Split(';');
            
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                dijak.Add(sor.ToList());
            }

            Console.WriteLine($"3. feladat:\n\t2007 és 2010 között {dijak.Count} díjat osztottak ki.");
            Console.Write($"4. feladat:\n\tKérem egy játékos nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("5. feladat:");
            if (dijak.Any(x => x[0] == nev))
            {
                for (int i = 0; i < dijak.Count; i++)
                {
                    if (dijak[i][0] == nev)
                    {
                        Console.WriteLine($"\tnév: {dijak[i][0]}");
                        Console.WriteLine($"\tdíj: {dijak[i][1]}");
                        Console.WriteLine($"\tév: {dijak[i][2]}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"\tNincs ilyen nevű jűtékos!");
            }

            Console.WriteLine("6. feladat:");
            for (int i = 0; i < dijak.Count; i++)
            {
                if (dijak[i][2] == "2009" && dijak[i][1] == "Gold Glove")
                    Console.WriteLine("\t" +dijak[i][0]);   
            }

            Console.WriteLine();
            Console.WriteLine("Nyomja meg az ENTER-t a kilépéshez");
            Console.ReadLine();

        }
    }
}
