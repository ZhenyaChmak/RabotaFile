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
                            
                            switch (b)
                            {
                                case 1:
                                    CreateXml createXml = new CreateXml();
                                    createXml.Create();
                                    break;
                                case 2:
                                    ReadXml readXml = new ReadXml();
                                    readXml.Read();
                                    break;
                                case 3:
                                    UpdateXml updateXml = new UpdateXml();
                                    updateXml.Update();
                                    break;
                                case 4:
                                    DeleteXml deleteXml = new DeleteXml();
                                    deleteXml.Delete();
                                    break;
                                case 5:
                                    ExitCase = true;
                                    break;
                                default:
                                    Console.WriteLine(Resource1.vuvod);
                                    break;
                            }
                                                       
                            if (ExitCase)
                            {
                                Console.WriteLine(Resource1.nasad);
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
                            switch (c)
                            {
                                case 1:
                                    CreateBin createBin = new CreateBin();
                                    createBin.Cread();
                                    break;
                                case 2:
                                    ReadBin readBin = new ReadBin();
                                    readBin.Read();
                                    break;
                                case 3:

                                    break;
                                case 4:
                                    DeleteBin deleteBin = new DeleteBin();
                                    deleteBin.Delete();
                                    break;
                                case 5:
                                    ExitCase = true;
                                    break;
                                default:
                                    Console.WriteLine(Resource1.vuvod);
                                    break;
                            }
                            if (ExitCase) {
                                Console.WriteLine(Resource1.nasad);
                                break;
                            }
                        }
                        while (true);
                      break;

                    case 3:
                        Console.WriteLine("Выход\n");
                        return;
                    default:
                        Console.WriteLine(Resource1.vuvod);
                        break;
                }
            }
            while (true);
        }   
    }
}
