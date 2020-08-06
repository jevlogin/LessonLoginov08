using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLibrary
{
    public class Complex
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

        static public Complex SumComplex(Complex a, Complex b)
        {
            return new Complex()
            {
                Re = a.Re + b.Re,
                Im = a.Im + b.Im
            };
        }

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }
    }
}
