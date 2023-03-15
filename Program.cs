


using DocumentFormat.OpenXml.Bibliography;
using knowledgeCheck2;
using System.Collections.Generic;
using System.Net.Http.Headers;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Product>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Product = new Product();
            Console.WriteLine("Please enter a product name.");
            Product.Name = Console.ReadLine();
            Console.WriteLine("Enter a price for " + Product.Name);
            Product.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the description for your Product. ");
            Product.Description = Console.ReadLine();
            

            recordList.Add(Product);
        }
        // Print out the list of records using Console.WriteLine()
        foreach (var record in recordList)
        {
            Console.WriteLine($"Product:" + record.Name + " " + record.Price+ " " + record.Description); 

        }
    }
}


