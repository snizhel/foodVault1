using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Output
    {
        //properties
        public string OutputId { get; set; }
        public DateTime DateOutput { get; set; }
        public int TotalPrice { get; set; }


        //constructor
        public Output() { }
    }
}
