using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie(3,3,3);
            Console.WriteLine("----------------");
            Serie(2, 3, 3);
            Console.ReadKey();
        }
        public static void Serie(int repeticiones, int limite, int giros)
        {
            for (int i = 0; i < giros; i++)
            {
                for (int j = 0; j < repeticiones; j++)
                {
                    for (int k = 0; k < limite; k++)
                    {
                        Console.Write((k + i) % limite + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
