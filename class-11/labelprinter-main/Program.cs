using System;
using System.Collections.Generic;

namespace labelprinter_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printers = new List<IBarcodePrinter>();
            printers.Add(new Elgin());
            printers.Add(new Zebra());

            Console.WriteLine("\nEnter the barcode to print on the label:");
            string barcode = Console.ReadLine();

            var product = new Product()
            {
                Id = 1,
                Barcode = barcode,
                Price = 10.99m
            };

            foreach (var printer in printers)
            {
                printer.PrintLabel(product);
            }
        }
    }
}