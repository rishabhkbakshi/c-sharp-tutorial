using System;

public class CustomerManagerWithAccessorMethods
{
    public static void Main()
	{
        Customer cust = new Customer();

        cust.SetID(1);
        cust.SetName("Amelio Rosales");

        Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.GetID(),
            cust.GetName());

        Console.ReadKey();
	}
}
