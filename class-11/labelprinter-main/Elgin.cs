namespace labelprinter_main
{
    public class Elgin : IBarcodePrinter
    {
        public void PrintLabel(Product product)
        {
            Console.WriteLine($"\nPrinting label for product {product.Id} on Elgin printer...");
            Console.WriteLine($"Barcode: {product.Barcode}");
            Console.WriteLine($"Price: ${product.Price}");
            Console.WriteLine($"Default settings:");
            Console.WriteLine($"- Resolution: 300dpi");
            Console.WriteLine($"- Label size: 10cm x 5cm");
            Console.WriteLine($"- Label type: Adhesive paper");
            Console.WriteLine($"**Label printed successfully!**");
        }
    }
}