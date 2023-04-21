using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorials
    {
        static void Main(string[] args)
        {
            int a,factorial = 1;

            Console.WriteLine("Ingresa el Numero del Factorial !: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El Factorial de: " + a + " es: " + factorial);
        }
    }
}