using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace WebshopRepository
{
    public class Cart
    {
        public string UserId { get; }
        public List<WebshopItem> Items { get; set; }
        public double TotalPrice { get; set; }

        public Cart() { }

        public Cart(string userId, WebshopItem item)
        {
            UserId = userId;
            Items.Add(item);
            TotalPrice = item.Price;
        }

        public override bool Equals(object obj)
        {
            return obj is Cart && ((Cart) obj).UserId == UserId;
        }

        public override int GetHashCode()
        {
            return UserId.GetHashCode();
        }
    }
}