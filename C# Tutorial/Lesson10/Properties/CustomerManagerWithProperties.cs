using System;

public class CustomerManagerWithProperties
{
	public static void Main()
	{
        Customer cust = new Customer();

        cust.ID = 1;
        cust.Name = "Amelio Rosales";

		Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.ID,
            cust.Name);

        Console.ReadKey();
	}
}

