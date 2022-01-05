using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_23
{
    class Program
    {
        int? myInt;

        static void Main(string[] args)
        {
            DateTime? startDate;
            
            // compiler error - Use of unassigned local variable 'startDate'
            //Console.WriteLine("startDate: " + startDate);
            
            startDate = DateTime.Now;

            Console.WriteLine("startDate: " + startDate);
            
            bool isNull = startDate == null;

            Console.WriteLine("isNull: " + isNull);

            int? unitsInStock = 5;

            Console.WriteLine("unitsInStock: " + unitsInStock);

            unitsInStock = null;

            Console.WriteLine("unitsInStock: " + unitsInStock);

            Console.ReadKey();
        }
    }
}
