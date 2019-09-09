using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_information
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name = " ";
            String Age = " ";
            String Address = " ";
            String Contact = " ";

            Console.WriteLine("Enter your name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            Age = Console.ReadLine();
            Console.WriteLine("Enter your address :");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your contact :");
            Contact = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Name :");
            Console.WriteLine(Name);
            Console.WriteLine("Age :");
            Console.WriteLine(Age);
            Console.WriteLine("Address :");
            Console.WriteLine(Address);
            Console.WriteLine("Contact :");
            Console.WriteLine(Contact);
            Console.ReadLine();
        }
    }
}
