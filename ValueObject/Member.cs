using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Member
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }
        public Member()
        {

        }
        public Member(string username, string password, string email, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.isAdmin = isAdmin;
        }
    }
}
