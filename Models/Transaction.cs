namespace Models
{    
    public class Transaction
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateOnly Date { get; set; }

        public decimal Value { get; set; }

        public TransactionType Type { get; set; }

        public int CategoryId {  get; set; }   
        
        public int SubCategoryId { get; set; }
    }

    public enum TransactionType { Income, Expense }
}
