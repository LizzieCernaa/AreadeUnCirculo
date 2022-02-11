using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDeUnCriculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que haya el area de un circulo" );

            Console.WriteLine("Ingresea el radio:");
            int r = int.Parse( Console.ReadLine() );

            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("El resultado es: " + area);

            Console.ReadKey();

        }
    }
}
