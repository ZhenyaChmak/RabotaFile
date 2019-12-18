using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace работа_с_файлами
{
    [Serializable]

    public class Person
    {
        public int Id;
        public string Surname;
        public DateTime DateOfBirth;
        private static int count = 1;

        public Person()
        {
            this.Id = count++;
        }

        public Person(string Surname, DateTime DateOfBirth):this()
        {
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
        }

    }
}
