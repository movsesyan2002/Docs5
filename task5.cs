// // Task 5: Calculate Area and Perimeter
// // Task: Write a program for circle basic calculations:
// // Write a method that calculates area and perimeter of a circle from radius.
// // Use ref and out in method parameters.
// // Call it with a user-provided radius value.

// class Program
// {
//     static void Calculate(ref double radius, out double area, out double perimeter)
//     {   
//         area = 3.14f * radius * radius;
//         perimeter = radius * radius;
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Please enter radius: ");
//         double radius;
//         while (double.TryParse(Console.ReadLine(), out radius) == false)
//         {
//             Console.WriteLine("You enter invalid value try again");
//         }
//         double area;
//         double perimeter;
//         Calculate(ref radius, out area, out perimeter);

//         Console.WriteLine($"Area is {area}");
//         Console.WriteLine($"Perimeter is {perimeter}");
//     }
// }


