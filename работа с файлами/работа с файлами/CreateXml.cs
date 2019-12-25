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
    [Serializable]
   public class CreateXml : Xml
    {
        public void Create()                        
        {
            /*for (int i = 0; i < 5; i++)
            {
                person.Add(new Person(("name_" + (i + 1)),("Surname_"+(i+1)), new DateTime(2011,11,11)));
            }*/
           person.Add(new Person("Zhenya", "Chmak", new DateTime(1990, 03, 05))); 

            using (FileStream fs = new FileStream(WayPerson, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
            }
            Console.WriteLine(" Файл создан.");
        }             
    }
}
