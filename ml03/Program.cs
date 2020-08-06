using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ml03
{
    [Serializable]
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        private int age;
        public int Age { get => age; set { if (value > 0) age = value; } }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {Age}";
        }
    }
    class Program
    {
        static void SaveAsXmlFormat(List<Student> students, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, students);
            fStream.Close();
        }

        static void LoadASXmlFormat(ref List<Student> students, string fileName)
        {
            //  Считать класс List<Student> из файла fileName формата XML
            //  Обратите внимание, что этот пример показывает нам, что List<Student> не более, 
            //  чем класс, его структура более сложная и для ее понимания потребуется некоторый опыт
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            students = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Максим", "Кузнецов", 25));
            students.Add(new Student("Евгений", "Логинов", 24));
            students.Add(new Student("Александр", "Замковой", 28));

            SaveAsXmlFormat(students, "data.xml");

            LoadASXmlFormat(ref students, "data.xml");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
