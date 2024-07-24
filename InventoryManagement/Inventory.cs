namespace InventoryManagement
{
    class Inventory
    {
        private List<Product> products = new List<Product>();

        // Encapsulation, Managing list of products through methods
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("The inventory is empty.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.Display();
                }
            }
        }

        public void DisplayProductsByCategory<T>() where T : Product
        {
            var filteredProducts = products.OfType<T>().ToList();
            if (filteredProducts.Count == 0)
            {
                Console.WriteLine($"No products found in the {typeof(T).Name} category.");
            }
            else
            {
                foreach (var product in filteredProducts)
                {
                    product.Display();
                }
            }
        }

        public Product? SearchProductByName(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Product? SearchProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public bool RemoveProductByName(string name)
        {
            var product = SearchProductByName(name);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product removed successfully!");
                return true;
            }
            Console.WriteLine("Product not found.");
            return false;
        }

        public bool RemoveProductById(int id)
        {
            var product = SearchProductById(id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product removed successfully!");
                return true;
            }
            Console.WriteLine("Product not found.");
            return false;
        }
    }
}
