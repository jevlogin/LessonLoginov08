using ComplexLibrary;
using System;


/**
 * 
 * Разделение логики и интерфейса. Понятие.
 * 
 * */


namespace les04
{

    class Program
    {
        static void Main(string[] args)
        {
            Complex z1;
            Console.Write($"Введите z1 - например, 4.5,5.2: ");
            var f = Complex.TryParse(Console.ReadLine(), out z1);

            Complex z2;
            Console.Write($"Введите z2 - например, 4.5,5.2: ");
            f &= Complex.TryParse(Console.ReadLine(), out z2);

            if (!f)
            {
                Console.WriteLine("Данные кривые");
            }

            if (f)
            {
                Console.WriteLine(Complex.SumComplex(z1, z2));
            }

            Console.ReadKey();
        }

    }
}
