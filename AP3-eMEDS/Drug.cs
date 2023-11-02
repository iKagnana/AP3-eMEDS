using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Target { get; set; }
        public double Price { get; set; }
        public int Stocks { get; set; } 

        // constructor when get data from db
        public Drug(int Id, string Name, string Description, string Target, double Price, int Stocks) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Target = Target;
            this.Price = Price;
            this.Stocks = Stocks;
        }

        // constructor for adding data in db
        public Drug(string Name, string Description, string Target, double Price, int Stocks)
        {
            this.Name = Name;
            this.Description = Description;
            this.Target = Target;
            this.Price = Price;
            this.Stocks = Stocks;
        }

    }
}
