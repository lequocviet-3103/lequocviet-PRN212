namespace BusinessObjects
{
    public partial class Product
    {
        public Product()
        {
        }

        public Product(int id, string name, int catId, short unitsInStock, decimal price)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.CategoryID = catId;
            this.UnitsInStock = unitsInStock;
            this.UnitPrice = price;

        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
