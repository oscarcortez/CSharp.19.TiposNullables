using System;

namespace ConsoleApp4TiposNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int? enteroNulo = null;
            enteroNulo = 123;

            Console.WriteLine($"Entero Nulo: {enteroNulo} {enteroNulo.Value}");
            int enteroNormal = 0;
            if(enteroNulo.HasValue)
            {
                // enteroNormal = enteroNulo;
                Console.WriteLine($"SI tiene value");
                enteroNormal = enteroNulo.Value;
            }

        }
    }
}
