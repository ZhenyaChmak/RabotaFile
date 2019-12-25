using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace работа_с_файлами
{
    [Serializable]
   public class Xml : Person
    {
     public string WayPerson = ConfigurationManager.AppSettings["WayPerson"];
     public XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
     public List<Person> person = new List<Person>();
    }
}
