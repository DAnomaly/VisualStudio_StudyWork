using System;
using System.Xml.Serialization;

namespace TestApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            DataInfo data = new DataInfo
            {
                FileName = "data.dat",
                Content = "내용이 적힙니다.",
                SetTime = DateTime.Now.Ticks
            };

            XmlSerializer xs = new XmlSerializer(typeof(DataInfo));
            xs.Serialize(Console.Out, data);

            while (true) {  }
        }
    }
}
