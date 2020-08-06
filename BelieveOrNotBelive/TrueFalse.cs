using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelive
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }
    class TrueFalse
    {
        private string fileName;
        List<Question> questions;
        public string FileName
        {
            set
            {
                fileName = value;
            }
        }

        public TrueFalse(string fileName)
        {
            FileName = fileName;
            questions = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            questions.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (questions != null && index < questions.Count && index >= 0)
            {
                questions.RemoveAt(index);
            }
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return questions[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, questions);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            questions = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count => questions.Count;
    }
}
