namespace G_NET_60_ADV_C__02;

internal class Program
{
    static void Main(string[] args)
    {
        #region Task01
        List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };


        //static List<Product> SearchProducts(List<Product> products, ProductFilter filter)
        //{
        //    List<Product> result = new List<Product>();

        //    foreach (Product product in products)
        //    {
        //        if (filter(product))
        //        {
        //            result.Add(product);
        //        }
        //    }

        //    return result;
        //}

        //static void PrintProducts(string title, List<Product> products)
        //{
        //    Console.WriteLine($"--- {title} ---");

        //    foreach (Product product in products)
        //    {
        //        Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
        //    }

        //    Console.WriteLine();
        //}



        //PrintProducts("Electronics",
        //  SearchProducts(catalog, p => p.Category == "Electronics"));

        //PrintProducts("Under $50",
        //    SearchProducts(catalog, p => p.Price < 50));

        //PrintProducts("In Stock",
        //    SearchProducts(catalog, p => p.Stock > 0));

        //PrintProducts("Clothing Under $100",
        //    SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100));


        #endregion


        #region Task02(3)


        //// Uses the built-in Action<Product> delegate.
        //// Action is used because we only perform an operation (printing)
        //// without returning any value.
        //static void PrintReport(List<Product> products, Action<Product> report)
        //{
        //    foreach (Product product in products)
        //    {
        //        report(product);
        //    }
        //}

        //Console.WriteLine("--- Short Report ---");

        //PrintReport(catalog, product =>
        //{
        //    Console.WriteLine($"{product.Name} - ${product.Price}");
        //});

        //Console.WriteLine();

        //Console.WriteLine("--- Detailed Report ---");

        //PrintReport(catalog, product =>
        //{
        //    Console.WriteLine($"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}");
        //});








        #endregion


        #region Task3.2

        // Uses the built-in Func<Product, T> delegate.
        // Func is used because it transforms a Product into another type
        // and returns the transformed value.
        //static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transformer)
        //{
        //    List<T> result = new List<T>();

        //    foreach (Product product in products)
        //    {
        //        result.Add(transformer(product));
        //    }

        //    return result;
        //}


        //Console.WriteLine("--- Summary List ---");

        //List<string> summary = TransformProducts(catalog,
        //    product => $"{product.Name} (${product.Price})");

        //foreach (string item in summary)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();

        //Console.WriteLine("--- Price Labels ---");

        //List<string> labels = TransformProducts(catalog,
        //    product => product.Price > 100 ? "Expensive!" : "Affordable");

        //for (int i = 0; i < catalog.Count; i++)
        //{
        //    Console.WriteLine($"{catalog[i].Name}: {labels[i]}");
        //}






        #endregion



        #region Task 3.3

        // Uses the built-in Predicate<Product> delegate.
        // Predicate is used because it checks a condition and returns true or false.
        static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (condition(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }


            Console.WriteLine("--- Low-Stock Alert ---");

            List<Product> lowStockProducts = FilterProducts(catalog,
                product => product.Stock < 20);

            foreach (Product product in lowStockProducts)
            {
                Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            }


        #endregion










        

    }
}



