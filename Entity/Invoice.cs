using System;
using System.Collections.Generic;
using Inventory.Entity.Transaction;

namespace Inventory.Entity
{
    public class Invoice
    {
        public DateTime InvoiceDateTime { get; set; } 

        public string InvoiceNumber { get; set; }

        public string GlobalUniqueIdentifier { get; set; }

        public Party Seller { get; set; }

        public Party Buyer { get; set; }

        public IDictionary<Good,int> GoodsInTransact { get; set; }

        public IList<ITax> Taxes { get; set; }

        public IList<Charges> AdditionalCharges { get; set; }

        public IList<Discount> Discounts { get; set; }

        public double TotalAmount { get; set; }

        public IList<Transactions> ReceivedAmounts { get; set; }

    }
}
