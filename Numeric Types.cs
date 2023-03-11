using System;

namespace NumericTypes
{
    class Program
     {
        public static void Main()
        {
            Console.WriteLine("Enter length of the rectangle: ");
            int Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of the rectangle: ");
            int Width = Convert.ToInt32(Console.ReadLine());

            int Area = Length * Width;
            Console.WriteLine("The area of the rectable = " + Area);

        }
     }

}
