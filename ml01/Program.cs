using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ml01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Используется для получения объекта System.Type для типа.
            // Выражение typeof принимает следующую форму:

            Type type = typeof(int);
            Console.WriteLine(type);

            // Для получения типа выражения во время выполнения можно 
            // воспользоваться методом платформы.NET GetType, как показано в следующем примере:
            int i = 0;
            Type type1 = i.GetType();
            Console.WriteLine(type1);

            Console.ReadKey();
        }
    }
}
