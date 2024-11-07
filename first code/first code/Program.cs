using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_code
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Enter your name");

            string username = Console.ReadLine();
            Console.WriteLine($"my name is {username}");
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine($"my password is {password}");
            if(username=="Abdullah" && password == "220"|| username =="amna" && password == "221")
            {
                Console.WriteLine("login");
            }
            else
            {
                Console.WriteLine("error");
            }
          

            Console.ReadKey();
        }
    }
}
