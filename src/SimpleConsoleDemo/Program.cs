using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleConsoleDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola comunidad Docker");
            string entrada = Console.ReadLine();
            Console.WriteLine("Gracias {0}", entrada);
        }
    }
}
