using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class PersonalInfo
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public int age { get; set; }
        public string occupation { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(int id, string fullname, int age, string occupation)
        {
            this.id = id;
            this.fullname = fullname;
            this.age = age;
            this.occupation = occupation;
        }
    }
}
