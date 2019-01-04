namespace Inventory.Entity.Transaction
{
    public interface ITransactionMode
    {
         string TransactionModeName { get; set; }
         string Description { get; set; }
    }
}