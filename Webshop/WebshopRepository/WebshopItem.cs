using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopRepository
{
    public class WebshopItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public int NumberOfItems { get; set; }
        public bool Sale { get; set; }
        public double SalePrice { get; set; }
        public string Description { get; set; }

        public WebshopItem() { }
        

    }
}
