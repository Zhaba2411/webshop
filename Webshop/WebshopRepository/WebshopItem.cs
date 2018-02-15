using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopRepository
{
    public class WebshopItem
    {
        public string Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }

        public bool Available
        {
            get { return NumberOfItems != 0; }
        }

        public int NumberOfItems { get; set; }

        public bool Sale
        {
            get
            {
                return SalePrice.HasValue;
            }
        }

        public Double? SalePrice { get; set; }
        public string Description { get; set; }

        public WebshopItem() { }

        public WebshopItem(string name, double price, int numberOfItems, double salePrice,
            string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            NumberOfItems = numberOfItems;
            SalePrice = salePrice;
            Description = description;
        }

        public static bool operator ==(WebshopItem i1, WebshopItem i2)
        {
            if (ReferenceEquals(i1, i2))
            {
                return true;
            }
            if (ReferenceEquals(i1, null) || ReferenceEquals(i2, null))
            {
                return false;
            }

            return i1.Equals(i2);
        }

        public static bool operator !=(WebshopItem i1, WebshopItem i2)
        {
            return !(i1 == i2);
        }

        public override bool Equals(object obj)
        {
            return obj is WebshopItem && ((WebshopItem) obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
