
namespace G_NET_60_ADV_C__02
{
    public delegate bool ProductFilter(Product product);

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }


    }
}
