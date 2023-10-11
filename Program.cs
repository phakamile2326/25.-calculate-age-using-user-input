using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _25.calculate_age_using_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("what year were you born?");
            int birthYear = int.Parse(Console.ReadLine());


            int age = 2023 - birthYear;

            Console.WriteLine(" Hi" + " you are " + name + " and you are " + age + " years old.");
            Console.Read();

             

        }
    }
}
