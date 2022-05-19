using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class User
    {
        //properties
        public int Id { get; set; }
        public string DisplayNameUser { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int IdRole { get; set; }

        //constructor
        public User() { }
    }
}
