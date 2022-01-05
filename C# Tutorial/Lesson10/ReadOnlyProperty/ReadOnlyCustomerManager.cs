using System;

public class ReadOnlyCustomerManager
{
	public static void Main()
	{
        Customer cust = new Customer(1, "Amelio Rosales");

        Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.ID,
            cust.Name);

        Console.ReadKey();
    }
}

