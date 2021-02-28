using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndLINQ
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}
