using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string username= Console.ReadLine();
            Console.WriteLine("Enter password" );
            string password = Console.ReadLine();
                    if (string.IsNullOrEmpty( username )  ||string.IsNullOrEmpty(password))
                    {
                          Console.WriteLine("Please provide username and password");
                    }
                    else if (username == "suma1234" && password =="sumalatha@123")
                    {
                        Console.WriteLine("Sign Success");
                    }
        }
    }
}
