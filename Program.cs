using System;
using System.Collections.Generic;
using System.Linq;

// Define a simple Customer class
class Customer
{
    public string CompanyName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
}

class Program
{
    static void Main()
    {
        // Sample customer list (simulates database data)
        List<Customer> customers = new List<Customer>
        {
            new Customer { CompanyName = "Around the Horn", City = "London" },
            new Customer { CompanyName = "B's Beverages", City = "London" },
            new Customer { CompanyName = "Consolidated Holdings", City = "London" },
            new Customer { CompanyName = "Eastern Connection", City = "London" },
            new Customer { CompanyName = "North/South", City = "London" },
            new Customer { CompanyName = "Seven Seas Imports", City = "London" },
            new Customer { CompanyName = "White Clover Markets", City = "Seattle" }
        };

        // Ask user to enter a city
        Console.Write("Enter the name of a city: ");
        string? inputCity = Console.ReadLine();

        // Validate user input
        if (string.IsNullOrWhiteSpace(inputCity))
        {
            Console.WriteLine("City name cannot be empty.");
            return;
        }

        // Use LINQ to filter customers by city (case-insensitive)
        var matchingCustomers = customers
            .Where(c => c.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
            .ToList();

        // Show results
        Console.WriteLine($"\nThere are {matchingCustomers.Count} customers in {inputCity}:");

        foreach (var customer in matchingCustomers)
        {
            Console.WriteLine(customer.CompanyName);
        }
    }
}
