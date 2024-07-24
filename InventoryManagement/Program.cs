namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Update Product By ID");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        ShowAddProductMenu(inventory);
                        break;
                    case "2":
                        ShowRemoveProductMenu(inventory);
                        break;
                    case "3":
                        ShowDisplayProductMenu(inventory);
                        break;
                    case "4":
                        UpdateProductById(inventory);
                        break;
                    case "5":
                        continueRunning = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShowAddProductMenu(Inventory inventory)
        {
            bool continueAdding = true;
            while (continueAdding)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Grocery");
                Console.WriteLine("3. Add Clothing");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        AddElectronics(inventory);
                        break;
                    case "2":
                        AddGrocery(inventory);
                        break;
                    case "3":
                        AddClothing(inventory);
                        break;
                    case "4":
                        continueAdding = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShowRemoveProductMenu(Inventory inventory)
        {
            bool continueRemoving = true;
            while (continueRemoving)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Remove by Name");
                Console.WriteLine("2. Remove by ID");
                Console.WriteLine("3. Back to Main Menu");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        RemoveProductByName(inventory);
                        break;
                    case "2":
                        RemoveProductById(inventory);
                        break;
                    case "3":
                        continueRemoving = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShowDisplayProductMenu(Inventory inventory)
        {
            bool continueDisplaying = true;
            while (continueDisplaying)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display All Products");
                Console.WriteLine("2. Display Electronics");
                Console.WriteLine("3. Display Groceries");
                Console.WriteLine("4. Display Clothing");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        inventory.DisplayProducts();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        inventory.DisplayProductsByCategory<Electronics>();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        inventory.DisplayProductsByCategory<Grocery>();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        inventory.DisplayProductsByCategory<Clothing>();
                        Console.ReadLine();
                        break;
                    case "5":
                        continueDisplaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddElectronics(Inventory inventory)
        {
            Electronics electronics = new Electronics();

            Console.Write("Enter name: ");
            electronics.Name = Console.ReadLine() ?? "";

            Console.Write("Enter price: ");
            electronics.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter warranty period (months): ");
            electronics.WarrantyPeriod = Convert.ToInt32(Console.ReadLine());

            inventory.AddProduct(electronics);
            Console.ReadLine();
        }

        static void AddGrocery(Inventory inventory)
        {
            Grocery grocery = new Grocery();

            Console.Write("Enter name: ");
            grocery.Name = Console.ReadLine() ?? "";

            Console.Write("Enter price: ");
            grocery.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter expiry date (yyyy-mm-dd): ");
            grocery.ExpiryDate = Convert.ToDateTime(Console.ReadLine());

            inventory.AddProduct(grocery);
            Console.ReadLine();
        }

        static void AddClothing(Inventory inventory)
        {
            Clothing clothing = new Clothing();

            Console.Write("Enter name: ");
            clothing.Name = Console.ReadLine() ?? "";

            Console.Write("Enter price: ");
            clothing.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter size: ");
            clothing.Size = Console.ReadLine() ?? "";

            inventory.AddProduct(clothing);
            Console.ReadLine();
        }

        static void RemoveProductByName(Inventory inventory)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine() ?? "";
            inventory.RemoveProductByName(name);
            Console.ReadLine();
        }

        static void RemoveProductById(Inventory inventory)
        {
            Console.Write("Enter product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveProductById(id);
            Console.ReadLine();
        }

        static void UpdateProductById(Inventory inventory)
        {
            Console.Write("Enter product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var product = inventory.SearchProductById(id);

            if (product != null)
            {
                product.EditDetails();
                Console.WriteLine("Product details updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            Console.ReadLine();
        }
    }
}
