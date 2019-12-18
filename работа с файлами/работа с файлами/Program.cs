using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace работа_с_файлами
{
    [Serializable]
    public class Program
    {
        static void Main(string[] args)
        {
            var WayPerson = ConfigurationManager.AppSettings["WayPerson"];
            var WayInstitution = ConfigurationManager.AppSettings["WayInstitution"];

            int a;
            do
            {
                Console.WriteLine("Меню:\n  1.Человек\n  2.Учреждение\n  3.Выход\n");
                int.TryParse(Console.ReadLine(), out a);
                bool ExitCase = false;

                switch (a)
                {
                    case 1:
                        int b;
                        do
                        {
                            Console.WriteLine("Человек:\n 1.Создать\n 2.Вывести на экран\n 3.Редактировать\n 4.Удалить\n 5.Назад\n");
                            int.TryParse(Console.ReadLine(), out b);
                            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
                            
                            switch (b)
                            {
                                case 1:
                                    List<Person> person = new List<Person>();

                                    for (int i = 0; i < 5; i++)
                                    {
                                        person.Add(new Person(("name_" + (i + 1)), new DateTime(2011 - 11 - 11)));
                                    }
                                                                       
                                    using (FileStream fs = new FileStream(WayPerson, FileMode.OpenOrCreate))
                                    {
                                        formatter.Serialize(fs, person);
                                    }
                                    Console.WriteLine(" Файл создан");

                                    break;
                                case 2:
                                    List<Person> newPersone;
                                    using (FileStream fs = new FileStream(WayPerson, FileMode.OpenOrCreate))
                                    {
                                        newPersone = (List<Person>)formatter.Deserialize(fs);
                                        foreach (Person per in newPersone)
                                        {
                                            Console.WriteLine($"Name:{per.Surname}\t Date:{per.DateOfBirth}");
                                        }
                                        Console.WriteLine();
                                    }
                                        break;
                                case 3:
                                    break;
                                case 4:
                                    XmlDocument xDoc = new XmlDocument();                                    //создаем обект
                                    xDoc.Load(WayPerson);                                                    //загружаем в него файл
                                    XmlElement xRoot = xDoc.DocumentElement;                                 //получаем корневой элемент документа
                                    XmlNode firstNode = xRoot.FirstChild;                       
                                    xRoot.RemoveAll();
                                    xDoc.Save(WayPerson);
                                    break;
                                case 5:
                                    ExitCase = true;
                                    break;
                                default:
                                    Console.WriteLine("Ввели неверно, повторите");
                                    break;
                            }
                                                       
                            if (ExitCase)
                            {
                                Console.WriteLine(" Назад <-");
                                break;
                            }
                        }
                        while (true);
                    break;

                    case 2:
                        int c;
                        do
                        {
                            Console.WriteLine("Учреждение:\n 1.Создать\n 2.Вывести на экран\n 3.Редактировать\n 4.Удалить\n 5.Назад\n");
                            int.TryParse(Console.ReadLine(), out c);
                            BinaryFormatter formatter = new BinaryFormatter();
                            switch (c)
                            {
                                case 1:
                                    List<Institution> institutions = new List<Institution>();

                                    for (int i = 0; i < 5; i++)
                                    {
                                        institutions.Add(new Institution(("name_" + (i + 1)), ("Street_"+ (i+1))));
                                    }

                                    using (FileStream fs = new FileStream(WayInstitution, FileMode.OpenOrCreate))
                                    {
                                        formatter.Serialize(fs, institutions);
                                    }
                                    Console.WriteLine(" Файл создан");

                                    break;
                                case 2:
                                    List<Institution> newInstitution;
                                    using (FileStream fs = new FileStream(WayInstitution, FileMode.OpenOrCreate))
                                    {
                                        newInstitution = (List<Institution>)formatter.Deserialize(fs);
                                        foreach (Institution per in newInstitution)
                                        {
                                            Console.WriteLine($"Address:{per.Address}\t Name:{per.Name} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                case 5:
                                    ExitCase = true;
                                    break;
                                default:
                                    Console.WriteLine("Ввели неверно, повторите");
                                    break;
                            }
                            if (ExitCase) {
                                Console.WriteLine(" Назад <-");
                                break;
                            }
                        }
                        while (true);
                      break;

                    case 3:
                        Console.WriteLine("Выход\n");
                        return;
                    default:
                        Console.WriteLine("Ввели неверно, повторите");
                        break;
                }
            }
            while (true);
        }   
    }
}
