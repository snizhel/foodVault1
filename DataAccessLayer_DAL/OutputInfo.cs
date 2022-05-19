using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class OutputInfo
    {
        //properties
        public string Id { get; set; }
        public string IdFood { get; set; }
        public string IdOutput { get; set; }
        public string IdInputInfo { get; set; }
        public int IdCustomer { get; set; }
        public int CountOutput { get; set; }
        public float OutputPrice { get; set; }
        public string StatusOutput { get; set; }

        //constructor
        public OutputInfo() { }
    }
}
