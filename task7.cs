// Task 7: Solve Quadratic Equation
// Task: Write a program for solving Quadratic Equation:
// Write a method that calculates two roots using the quadratic formula: x = [-b ± √(b2 - 4ac)]/2a.
// Use ref and out in method parameters.
// Call it with a user-provided a, b and c values.

// class Program
// {
//     static void Quadratic(ref double a, ref double b, ref double c, out double x1, out double x2)
//     {
//         double discriminant = b * b - 4 * a * c;

//         if (discriminant < 0) 
//         {
//             x1 = double.NaN;
//             x2 = double.NaN;
//             Console.WriteLine("Discriminant lesser 0");
//             return;
//         }
//         x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
//         x2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));


//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a,b and c parameters");
//         double a, b, c = 0;
//         double.TryParse(Console.ReadLine(),out a);

//         if (a == 0) {
//             Console.WriteLine("A cannot be 0");
//             return;
//         }

//         double.TryParse(Console.ReadLine(), out b);
//         double.TryParse(Console.ReadLine(), out c);

//         double x1;
//         double x2;

//         Quadratic(ref a, ref b, ref c, out x1, out x2);

//         if (double.IsNaN(x1) && double.IsNaN(x2))
//         {
//             Console.WriteLine($"x1 is {x1}\nx2 is {x2}");
//         }

//         Console.WriteLine($"x1 is {x1}\nx2 is {x2}");

//     }
// }