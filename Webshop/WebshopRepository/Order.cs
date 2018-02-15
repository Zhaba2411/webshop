using System;
using System.Dynamic;

namespace WebshopRepository
{
    public class Order
    {
        public string Id { get;  }
        public Cart Cart {get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Order() { }

        public Order(Cart cart, string mail, string phoneNumber, string address)
        {
            Id = Guid.NewGuid().ToString();
            Cart = cart;
            Mail = mail;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            return obj is Order && ((Order) obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}