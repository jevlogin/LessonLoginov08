using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Разделение логики и интерфейса. Понятие.
 * 
 * */


namespace les04
{
    class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
    }
    class Program
    {
        static public void SumComplex(Complex a, Complex b)
        {
            double re, im;

            Console.Write("Введите a.re: ");
            bool f = double.TryParse(Console.ReadLine(), out re);

            Console.Write("Введите a.im: ");
            f &= double.TryParse(Console.ReadLine(), out im);
            if (!f)
            {
                Console.WriteLine($"Данные кривые");
                return;
            }

            a = new Complex() { Re = re, Im = im };

            Console.Write("Введите b.re: ");
            f = double.TryParse(Console.ReadLine(), out re);

            Console.Write("Введите b.im: ");
            f &= double.TryParse(Console.ReadLine(), out im);
            if (!f)
            {
                Console.WriteLine($"Данные кривые");
                return;
            }

            b = new Complex() { Re = re, Im = im };

            Console.WriteLine($"a + b = {a.Re + b.Re} + {a.Im + b.Im}");
        }
        static void Main(string[] args)
        {
            Complex z1 = new Complex();
            Complex z2 = new Complex();

            SumComplex(z1, z2);

            Console.ReadKey();
        }
    }
}
