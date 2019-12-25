using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace работа_с_файлами
{
    [Serializable]
    public class DeleteBin : Bin
    {
        public void Delete()
        {
            try
            {
                // смог сделать удаление только так
                string f = WayInstitution;
                File.Delete(f);

                Console.WriteLine(" Файл удален.");
            }
            catch
            {
                Console.WriteLine(Resource1.uckluchenie);
            }
        }
    }
}
