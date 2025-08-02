namespace OnlineShopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        // we add ? to accept the null values.
        public string? ProductImage { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }//this field is not in the table so we make virtual
    }
}
