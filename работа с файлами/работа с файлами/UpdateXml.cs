using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace работа_с_файлами
{
    [Serializable]
    class UpdateXml : Xml
    {
        public void Update()
        {
            try
            {
                int a;
                bool Nazad = false;
                do
                {
                    XDocument document = XDocument.Load(WayPerson);
                    Console.WriteLine("Редактировать:\n 1.Name\n 2.SurName\n 3.DateOfBirth\n 4.Назад");
                    int.TryParse(Console.ReadLine(), out a);
                    switch (a)
                    {
                        case 1:
                            document.Root.Element("Person").Element("Name").SetValue(Console.ReadLine());
                            Console.WriteLine(" Name отредактирован");
                            break;
                        case 2:
                            document.Root.Element("Person").Element("Surname").SetValue(Console.ReadLine());
                            Console.WriteLine(" Surname отредактирован");
                            break;
                        case 3:
                            //необходимо правильноесоблюдение ввода даты, иначе при выводе возникнет исключени
                            //формат ввода 0000-00-00
                            document.Root.Element("Person").Element("DateOfBirth").SetValue(Console.ReadLine()); 
                            Console.WriteLine(" DateOFBirth отредактирован");
                            break;
                        case 4:
                            Nazad = true;
                            break;
                        default:
                            Console.WriteLine(Resource1.vuvod);
                            break;
                    }

                    if (Nazad)
                    {
                        Console.WriteLine(Resource1.nasad);
                        break;
                    }

                    document.Save(WayPerson);
                }
                while (true);
            }

            catch
            {
                Console.WriteLine(Resource1.uckluchenie);
            }
        }
    }
}
