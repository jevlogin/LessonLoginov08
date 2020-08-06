using ComplexLibrary;
using System;


/**
 * 
 * Разделение логики и интерфейса. Понятие.
 * 
 * */


namespace les04
{
    class MyClass : IViewInterface
    {
        public string Number1
        {
            get
            {
                Console.Write($"Введите z1 - например, 4.5,5.2: ");
                return Console.ReadLine();
            }
        }

        public string Number2
        {
            get
            {
                Console.Write($"Введите z2 - например, 4.5,5.2: ");
                return Console.ReadLine();
            }
        }

        public string OutputData
        {
            set
            {
                Console.WriteLine(value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass view = new MyClass();
            Adapter a = new Adapter(view);

            a.Sum();

            Console.ReadKey();
        }

    }
}
