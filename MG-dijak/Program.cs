using System;
using System.Collections.Generic;
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
            string fejlec = "Díjak";
            Console.WriteLine(fejlec);

            for (int i = 0; i < fejlec.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();




            Console.WriteLine();
            Console.WriteLine("Nyomja meg az ENTER-t a kilépéshez");
            Console.ReadLine();

        }
    }
}
