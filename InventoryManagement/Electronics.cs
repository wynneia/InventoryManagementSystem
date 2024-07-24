namespace InventoryManagement
{
    // Inheritance
   class Electronics : Product
    {
        public int WarrantyPeriod { get; set; } // in months

        // Polymorphism, Overriding the abstract method
        public override void Display()
        {
            Console.WriteLine($"ID: {Id}, Electronics: {Name}, Price: {FormatPrice(Price)}, Warranty: {WarrantyPeriod} months");
        }

        // Overriding method to edit details
        public override void EditDetails()
        {
            Console.Write("Enter new name: ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter new price: ");
            Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter new warranty period (months): ");
            WarrantyPeriod = Convert.ToInt32(Console.ReadLine());
        }
    }
}
