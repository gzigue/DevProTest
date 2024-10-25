using System;
using System.Collections.Generic;
using CodingTest;
using CodingTest.Enums;
using CodingTest.Models;

class Program
{
    static void Main()
    {
        // Logger - Usage examples
        string logFilePath = "application.log";
        Logger.LogMessage(logFilePath, "User logged in", LogLevel.INFO);
        Logger.LogMessage(logFilePath, "Failed login attempt", LogLevel.WARNING);
        Logger.LogMessage(logFilePath, "", LogLevel.ERROR);
        Logger.LogMessage(logFilePath, null, LogLevel.DEBUG);
        Logger.LogMessage(logFilePath, "Cat walking on the keyboard", LogLevel.CRITICAL);


        // InventoryManager - Usage examples
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 },
            new Product { Name = "Product AA", Price = 150, Stock = 2 },
            new Product { Name = "Product BB", Price = 250, Stock = 1 },
            new Product { Name = "Product CC", Price = 75, Stock = 7 },
            new Product { Name = "Product AB", Price = 175, Stock = 7 },
            new Product { Name = "Product AC", Price = 275, Stock = 6 },
        };

        Console.WriteLine("Products sorted by price (ascending):");
        var sortedProducts_PriceAscending = InventoryManager.SortProducts(products, "price", SortOrder.Ascending);

        foreach (var product in sortedProducts_PriceAscending)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }

        Console.WriteLine("\nProducts sorted by name (descending):");
        var sortedProducts_NameDescending = InventoryManager.SortProducts(products, "name", SortOrder.Descending);

        foreach (var product in sortedProducts_NameDescending)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }

        Console.WriteLine("\nProducts sorted by stock (descending):");
        var sortedProducts_StockDescending = InventoryManager.SortProducts(products, "stock", SortOrder.Descending);

        foreach (var product in sortedProducts_StockDescending)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}
