namespace Models
{
    public record SubCategory
    {
        public int Id;

        public required string Name;

        public int CategoryId;
    }
}
