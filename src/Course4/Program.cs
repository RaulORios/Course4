using System;
using System.Globalization;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {

            //____________________________________________________________________________//

            //While

            //Console.Write("Digite um número: ");
            //double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //while (n >= 0.0)
            //{
            //    double raiz = Math.Sqrt(n);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Numero negativo");

            //____________________________________________________________________________//

            //FOR

            Console.Write("Qunatos números inteiros você vai digitar: ");
            int cont = int.Parse(Console.ReadLine());

            int soma = 0;            
            for (int i = 1; i <= cont; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor #{i} = {n}");
                soma = soma + n;
            }

            Console.WriteLine($"A soma dos números digitados é {soma}");

            Console.ReadKey();

        }
    }
}
