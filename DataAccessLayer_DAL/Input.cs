using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Input
    {
        //properties
        public int InputId { get; set; }
        public DateTime DateInput { get; set; }
        public int TotalPrice { get; set; }
        public int IdSuplier { get; set; }


        //constructor
        public Input() { }
    }
}
