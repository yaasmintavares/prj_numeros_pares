using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_numero_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            for (c = 1; c <= 10; c++)
            {
                if (c % 1 == 0)
                    Console.WriteLine(c + "\n");
            }
            Console.WriteLine("\nPress.<ENTER> para finalizar\n");
            Console.ReadKey();
            {
                Console.ReadKey();
            }
        }
    }
}
