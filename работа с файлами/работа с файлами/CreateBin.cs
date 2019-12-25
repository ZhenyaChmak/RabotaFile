using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace работа_с_файлами
{
    public class CreateBin : Bin
    {
        public void Cread()
        {
            /* for (int i = 0; i < 5; i++)
             {
                 institutions.Add(new Institution(("name_" + (i + 1)), ("Street_" + (i + 1))));
             }*/
            institutions.Add(new Institution("Step", "Minsk"));

            using (FileStream fs = new FileStream(WayInstitution, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, institutions);
            }
            Console.WriteLine(" Файл создан");
        }
    }
}
