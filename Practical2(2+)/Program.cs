using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical2_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            string country, name;

            do
            {
                Console.WriteLine("Enter Your Name : ");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));

            do
            {
                Console.WriteLine("Enter Your Country : ");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));

            Console.WriteLine("Your Name is " + name + " from country " + country);
            Console.Read();
        }
    }
}
