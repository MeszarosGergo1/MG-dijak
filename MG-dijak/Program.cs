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


            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Nyomja meg az ENTER-t a kilépéshez");
            Console.ReadLine();

        }
    }
}
