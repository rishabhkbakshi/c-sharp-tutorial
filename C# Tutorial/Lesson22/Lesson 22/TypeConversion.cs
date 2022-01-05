using System;

class Program
{
    static void Main()
    {
        float lengthFloat = 7.35f;

        // lose precision - explicit conversion
        int lengthInt = (int)lengthFloat;

        // no problem - implicit conversion
        double lengthDouble = lengthInt;

        Console.WriteLine("lengthInt = " + lengthInt);
        Console.WriteLine("lengthDouble = " + lengthDouble);
        Console.ReadKey();
    }
}
