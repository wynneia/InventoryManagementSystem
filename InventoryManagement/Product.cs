using System.Globalization;

namespace InventoryManagement
{
    // Abstract base class, Abstraction
    abstract class Product
    {
        // Encapsulation, Private fields with public properties
        private static int nextId = 1;
        private int id;
        private string? name;
        private decimal price;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name!; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {
            id = nextId++;
        }

        // Abstraction
        public abstract void Display();

        public abstract void EditDetails();

        protected string FormatPrice(decimal price)
        {
            CultureInfo culture = new CultureInfo("id-ID");
            return price.ToString("C", culture);
        }
    }
}
