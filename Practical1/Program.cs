using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1();
            Pattern2();
            Pattern3();
            //Pattern();
            Console.Read();
        }

      
    
        
        
        private static void Pattern3()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        private static void Pattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        private static void Pattern1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

    }

}

