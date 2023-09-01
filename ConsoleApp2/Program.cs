using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un caracter: ");
            string caracter = Console.ReadLine();
            if (caracter == caracter.ToUpper());

            if (caracter == "A"
               || caracter == "E"
               || caracter == "I"
               || caracter == "O"
               || caracter == "U")
            {
                Console.WriteLine("Es una vocal");
            }
            else 
            {
                Console.WriteLine("No es una vocal");
            }
            Console.ReadLine();
        }
    }
}
