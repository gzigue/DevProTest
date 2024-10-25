using System;
using System.Collections.Generic;
using CodingTest.Models;
using CodingTest.Enums;

namespace CodingTest {

public class InventoryManager
{
    public static List<Product> SortProducts(List<Product> products, string sortKey, SortOrder sortOrder)
    {
        products.Sort((a, b) =>
        {
            int result = 0;
            switch (sortKey.ToLower())
            {
                case "name":
                    result = string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase);
                    break;
                case "price":
                    result = a.Price.CompareTo(b.Price);
                    break;
                case "stock":
                    result = a.Stock.CompareTo(b.Stock);
                    break;
                default:
                    throw new Exception("Invalid sort key");
            }

            return sortOrder == SortOrder.Ascending ? result : -result;
        });

        return products;
    }
}
}
