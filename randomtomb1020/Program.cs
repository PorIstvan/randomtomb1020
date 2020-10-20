using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtomb1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tb = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i] = rnd.Next(10, 100);

            }
            Console.WriteLine("A tomb elemei:");
            for (int i = 0; i < tb.Length; i++)
            {
                Console.WriteLine(tb[i]);

            }
            Console.ReadKey();
        }
    }
}
