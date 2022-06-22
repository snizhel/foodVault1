using System;

namespace DataAccessLayer_DAL
{
    public class Food
    {
        //properties
        public int FoodId { get; set; }
        public string DisplayNameFood { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int IDSuplier { get; set; }
        //DateOfManufacture
        public DateTime StartDate { get; set; }
        //ExpirationDate
        public DateTime EndDate { get; set; }

        //constructor
        public Food() { }
    }
}
