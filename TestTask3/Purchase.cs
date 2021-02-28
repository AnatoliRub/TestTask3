using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndLINQ
{
    public class Purchase
    {
        public int PurchaseId {get; set;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Purchase(int purchaseId, string name, decimal price)
        {
            PurchaseId = purchaseId;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Purchase: {Name} Price: {Price}";
        }
    }
}
