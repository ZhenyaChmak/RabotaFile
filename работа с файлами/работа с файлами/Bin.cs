using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace работа_с_файлами
{
   public class Bin : Institution
    {
       public string WayInstitution = ConfigurationManager.AppSettings["WayInstitution"];
       public BinaryFormatter formatter = new BinaryFormatter();
       public List<Institution> institutions = new List<Institution>();
    }
}
