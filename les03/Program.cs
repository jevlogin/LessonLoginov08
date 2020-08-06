using System;
using System.IO;
using System.Xml.Serialization;

namespace les03
{
    [Serializable]
    public class Student
    {
        private int age;
        public string FirstName;
        public string LastName;

        public int Age
        {
            get { return age; }
            set {if (value > 0) age = value; }
        }
        public override string ToString() => $"{FirstName}, {LastName}, {Age}";
    }
    class Program
    {
        static void SaveAsXmlFormat(Student obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Student));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }

        static Student LoadFromXmlFormat(string fileName)
        {
            Student student = new Student();
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Student));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            student = xmlFormat.Deserialize(fStream) as Student;
            fStream.Close();
            return student;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age = 20;
            student.FirstName = "Максим";
            student.LastName = "Кузнецов";
            SaveAsXmlFormat(student, "data.xml");
            student = LoadFromXmlFormat("data.xml");
            Console.WriteLine(student);

            Console.ReadKey();
        }
    }
}
