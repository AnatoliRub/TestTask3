using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndLINQ
{
    class PurchaseCategory
    {
        public int PurchaseId { get; set; }
        public int CategoryId { get; set; }

        public PurchaseCategory(int purchaseId, int categoryId)
        {
            PurchaseId = purchaseId;
            CategoryId = categoryId;
        }
    }
}
