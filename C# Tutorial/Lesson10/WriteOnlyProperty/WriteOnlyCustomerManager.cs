using System;

public class WriteOnlyCustomerManager
{
	public static void Main()
	{
        Customer cust = new Customer();

        cust.ID = 1;
        cust.Name = "Amelio Rosales";

        cust.DisplayCustomerData();

        Console.ReadKey();
    }
}

