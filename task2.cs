// Task 2:  Swap Two Numbers
// Task: Write a program to swap 2 numbers:
// Write a method to swap the values of two integers.
// Use ref in method parameters.
// Read 2 numbers from user input and validate the input values.


// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter 2 number");
//         Console.Write("Enter first number: ");
//         int number1 = 0;
//         int number2 = 0;
//         while (int.TryParse(Console.ReadLine(), out number1) == false) 
//         {
//             Console.WriteLine("You are enter invalid argument try again");
//         }
        
//         Console.Write("Enter second number: ");
//         while (int.TryParse(Console.ReadLine(), out number2) == false) 
//         {
//             Console.WriteLine("You are enter invalid argument try again");
//         }

//         Swap(ref number1, ref number2);
//         Console.WriteLine($"After swapping\n number1 is {number1}\n number2 is {number2}");
//     }

//     static void Swap(ref int number1, ref int number2)
//     {
//         int number = number1;
//         number1 = number2;
//         number2 = number;
//     }
// }