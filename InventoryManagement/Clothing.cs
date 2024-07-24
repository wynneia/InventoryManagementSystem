namespace InventoryManagement
{
    // Inheritance
    class Clothing : Product
    {
        public string? Size { get; set; }

        // Polymorphism, Overriding the abstract method
        public override void Display()
        {
            Console.WriteLine($"ID: {Id}, Clothing: {Name}, Price: {FormatPrice(Price)}, Size: {Size}");
        }

        // Overriding method to edit details
        public override void EditDetails()
        {
            Console.Write("Enter new name: ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter new price: ");
            Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter new size: ");
            Size = Console.ReadLine() ?? "";
        }
    }
}
