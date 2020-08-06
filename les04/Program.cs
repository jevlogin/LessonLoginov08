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

        static public bool TryParse(string s, out Complex z)
        {
            try
            {
                var data = s.Split(',');
                z = new Complex()
                {
                    Re = Convert.ToDouble(data[0]),
                    Im = Convert.ToDouble(data[1])
                };
                return true;
            }
            catch (Exception)
            {
                z = new Complex();
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }
    }
    class Program
    {
        static public Complex SumComplex(Complex a, Complex b)
        {
            return new Complex()
            {
                Re = a.Re + b.Re,
                Im = a.Im + b.Im
            };
        }

        static void Main(string[] args)
        {
            Complex z1;
            Console.WriteLine($"Введите 4.5,5.2");
            var f = Complex.TryParse(Console.ReadLine(), out z1);

            Complex z2;
            Console.WriteLine($"Введите 4.5,5.2");
            f &= Complex.TryParse(Console.ReadLine(), out z2);

            if (!f)
            {
                Console.WriteLine("Данные кривые");
            }

            if (f)
            {
                Console.WriteLine(SumComplex(z1, z2));
            }

            Console.ReadKey();
        }
    }
}
