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
            Complex z1 = new Complex();
            Complex z2 = new Complex();

            SumComplex(z1, z2);

            Console.ReadKey();
        }
    }
}
