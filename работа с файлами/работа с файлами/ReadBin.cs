using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_с_файлами
{
    public class ReadBin : Bin
    {
        public void Read()
        {
            try
            {
                Console.WriteLine(" Файл:");
                using (FileStream fs = new FileStream(WayInstitution, FileMode.OpenOrCreate))
                {
                    institutions = (List<Institution>)formatter.Deserialize(fs);
                    foreach (Institution per in institutions)
                    {
                        Console.WriteLine($"ID:{per.Id}\t Address:{per.Address}\t Name:{per.Name} ");
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
