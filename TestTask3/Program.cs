using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndLINQ
{
    class Program
    {
        static void Main()
        {
            List<Purchase> purchases = new List<Purchase>(){
                                                    new Purchase(1,"phone", 800),
                                                    new Purchase(2, "notebook", 1000),
                                                    new Purchase(3,"car", 2000),
                                                    new Purchase(4, "motorcycle", 1300),
                                                    new Purchase(5,"pen", 5),
                                                    new Purchase(6, "fish", 100),
                                                    new Purchase(7,"ice-cream", 20),
                                                    new Purchase(8, "paper", 80),
                                                    new Purchase(9,"ball", 280),
                                                    new Purchase(10, "boots", 370),
            };

            List<Category> categories = new List<Category>(){
                                                    new Category(1,"electronics"),
                                                    new Category(2, "computers and networks"),
                                                    new Category(3,"appliances"),
                                                    new Category(4, "construction and repair"),
                                                    new Category(5,"house and garden"),
                                                    new Category(6, "auto and moto"),
                                                    new Category(7,"beauty and sport"),
                                                    new Category(8, "children and mothers"),
                                                    new Category(9,"work and office"),
                                                    new Category(10, "food"),
            };

            List<PurchaseCategory> purchasesCategories = new List<PurchaseCategory>()
            {
                new PurchaseCategory(1,1),
                new PurchaseCategory(2,2),
                new PurchaseCategory(3,6),
                new PurchaseCategory(4,6),
                new PurchaseCategory(5,9),
                new PurchaseCategory(6,10),
                new PurchaseCategory(8,9)
            };

            var questionFirst = purchases.Where(item => item.Price > 400);
            Print(questionFirst);

            var questionSecond = purchases.Where(item => item.Name.StartsWith("p"));
            Print(questionSecond);

            var questionThird = from purchase in purchases
                         join purchaseCategory in purchasesCategories
                         on purchase.PurchaseId equals purchaseCategory.PurchaseId
                         join category in categories
                         on purchaseCategory.CategoryId equals category.CategoryId
                         select new {Purchase=purchase.Name, Category=category.Name };

            Print(questionThird);

            var questionFourth = from purchase in purchases
                         join purchaseCategory in purchasesCategories
                         on purchase.PurchaseId equals purchaseCategory.PurchaseId
                         join category in categories
                         on purchaseCategory.CategoryId equals category.CategoryId
                         orderby  purchase.Price
                         select new { Purchase = purchase.Name, Category = category.Name, purchase.Price };
            Print(questionFourth);

            var questionFifth = from purchase in purchases
                          join purchaseCategory in purchasesCategories
                          on purchase.PurchaseId equals purchaseCategory.PurchaseId
                          join category in categories
                          on purchaseCategory.CategoryId equals category.CategoryId
                          orderby purchase.Name
                          select new { Purchase = purchase.Name, Category = category.Name, purchase.Price };
            foreach (var item in questionFifth)
            {
                Console.WriteLine($"Purchase: {item.Purchase}; Category: {item.Category}; Price: {item.Price}");
            }
            Console.WriteLine("--------------");

            var questionSixth = from purchase in purchases
                          join purchaseCategory in purchasesCategories
                          on purchase.PurchaseId equals purchaseCategory.PurchaseId
                          join category in categories
                          on purchaseCategory.CategoryId equals category.CategoryId
                          orderby category.Name, purchase.Name, purchase.Price descending
                          select new { Purchase = purchase.Name, Category = category.Name, purchase.Price };
            foreach (var item in questionSixth)
            {
                Console.WriteLine($"Purchase: {item.Purchase}; Category: {item.Category}; Price: {item.Price}");
            }
            Console.WriteLine("--------------");

           
        }
        static void Print<T>(IEnumerable<T> collect)
        {
            foreach (var item in collect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
        }
    }
}
