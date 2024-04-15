using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace média_aritmética
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int valor3;
            int valor4;
            int total;
            string aux;

            Console.WriteLine("digite o primeiro valor:");
            aux = Console.ReadLine();
            valor1 = int.Parse(aux);

            Console.WriteLine("digite o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro valor:");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o quarto valor:");
            valor4 = int.Parse(Console.ReadLine());

            total = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine("o total é:");
            Console.WriteLine(total);
        }
    }
}
