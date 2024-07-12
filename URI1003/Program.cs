using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                int x, y, soma;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                soma = x + y;

                Console.WriteLine("SOMA = " + soma);

            }
        }
    }
}