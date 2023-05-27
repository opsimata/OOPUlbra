using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labelprinter_main
{
    public class Zebra : IBarcodePrinter
    {
        public void PrintLabel(Product product)
        {
            Console.WriteLine($"\nPrinting label for product {product.Id} on Zebra printer...");
            Console.WriteLine($"Barcode: {product.Barcode}");
            Console.WriteLine($"Price: ${product.Price}");
            Console.WriteLine($"Default settings:");
            Console.WriteLine($"- Resolution: 600dpi");
            Console.WriteLine($"- Label size: 15cm x 7cm");
            Console.WriteLine($"- Label type: Polyester");
            Console.WriteLine($"**Label printed successfully!**");
        }
    }
}