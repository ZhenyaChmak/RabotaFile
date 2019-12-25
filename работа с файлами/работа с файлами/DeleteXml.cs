using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace работа_с_файлами
{
    [Serializable]
    public class DeleteXml : Xml
    {

        public void Delete()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();                                    //создаем обект
                xDoc.Load(WayPerson);                                                    //загружаем в него файл
                XmlElement xRoot = xDoc.DocumentElement;                                 //получаем корневой элемент документа
                XmlNode firstNode = xRoot.FirstChild;
                xRoot.RemoveAll();
                xDoc.Save(WayPerson);
                Console.WriteLine(" Файл удален.");
            }
            catch
            {
                Console.WriteLine(Resource1.uckluchenie);
            }
        }
    }
}
