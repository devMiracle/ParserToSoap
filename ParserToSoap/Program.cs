using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace ParserToSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Oriana");
            string path = "test.soap";
            SoapFormatter soap = new SoapFormatter();

            //write
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    soap.Serialize(fs, person);
            //    Console.WriteLine("Объект сериализован");
            //}

            //read
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    Person person1 = (Person)soap.Deserialize(fs);
            //    Console.WriteLine("Объект десериализован");
            //    Console.WriteLine(person1.Name);
            //}

            Console.ReadKey(true);
        }
    }
}
