using System;


namespace Inventory.Entity.Transaction
{
    public class Transactions
    {
        public DateTime TransactionDateTime { get; set; }
        public double Amount { get; set; }
        public Party Payer { get; set; }
        public Party Receiver { get; set; }
        public string GUID { get; set; }
        public ITransactionMode TransactionMode { get; set; }

    }
}