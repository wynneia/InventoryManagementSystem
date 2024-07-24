namespace InventoryManagement
{
    // Inheritance
    class Grocery : Product
    {
        public DateTime ExpiryDate { get; set; }

        // Polymorphism, Overriding the abstract method
        public override void Display()
        {
            Console.WriteLine($"ID: {Id}, Grocery: {Name}, Price: {FormatPrice(Price)}, Expiry Date: {ExpiryDate.ToShortDateString()}");
        }

        // Overriding method to edit details
        public override void EditDetails()
        {
            Console.Write("Enter new name: ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter new price: ");
            Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter new expiry date (yyyy-mm-dd): ");
            ExpiryDate = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
