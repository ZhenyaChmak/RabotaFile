using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace работа_с_файлами
{
    [Serializable]

    class Institution
    {
        public int Id;
        public string Name;
        public string Address;
        private static int COUNT = 1;

        public Institution()
        {
            this.Id = COUNT++;
        }

        public Institution(string Name, string Address):this()
        {
            this.Name = Name;
            this.Address = Address;

        }

    }
}
