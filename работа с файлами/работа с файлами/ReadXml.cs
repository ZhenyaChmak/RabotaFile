using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace работа_с_файлами
{
   public class ReadXml : Xml
    {
        public void Read()
        {
            try
            {
                Console.WriteLine(" Файл:");
                using (FileStream fs = new FileStream(WayPerson, FileMode.OpenOrCreate))

                {
                    person = (List<Person>)formatter.Deserialize(fs);
                    foreach (Person per in person)
                    {
                        Console.WriteLine($"ID:{per.Id}\t Name:{per.Name}\t SurName:{per.Surname}\t Date:{per.DateOfBirth}");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine(Resource1.uckluchenie);
            }
        }
    }
}
