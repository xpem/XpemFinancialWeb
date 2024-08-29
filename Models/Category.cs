namespace Models
{
    public record Category
    {
        public int Id;

        public required string Name;

        //public string Color { get; set; }

        public TransactionType Type;

        public List<SubCategory>? SubCategories;

    }
}
