// // Task 1: Basic Calculator
// // Task: Write a program with methods for basic math operations:
// // Add(int a, int b), Subtract(int a, int b), Multiply(int a, int b), Divide(int a, int b)
// // Read 2 numbers from user input, read operation code and then display the result.
// // Close the program if received X from the user.
// // Use recursion to make the calculator run until it gets the X.

// using System;

// class Program
// {
//     static void Add(int number1, int number2)
//     {
//         Console.WriteLine($"the + operation result {number1 + number2}");
//         Calculator();
//     } 


//     static void Subtract(int number1, int number2)
//     {
//         Console.WriteLine($"the - operation result {number1 - number2}");
//         Calculator();
//     } 


//     static void Multiply(int number1, int number2)
//     {
//         Console.WriteLine($"the * operation result {number1 * number2}");
//         Calculator();
//     } 


//     static void Divide(int number1, int number2)
//     {
//         if (number2 == 0) {
//             Console.WriteLine("the number 2 is 0");
//             return;
//         }

//         Console.WriteLine($"the / operation result {number1 / number2}");
//         Calculator();
//     }

//     static void Calculator() 
//     {   
//         Console.WriteLine("Enter operation for exiting enter X");
//         string? operation = Console.ReadLine();

//         if (string.Compare(operation,"X") == 0) 
//         {
//             Console.WriteLine("I finished my work");
//             return;
//         }


//         Console.WriteLine("Enter 2 numbers ");
//         int number1, number2;
        
//         Console.Write("Enter first number ");
        
//         if (int.TryParse(Console.ReadLine(), out number1) == false) 
//         {
//             Console.WriteLine("First number Invalid argument");
//         }
        
//         Console.Write("Enter second number ");
        
//         if (int.TryParse(Console.ReadLine(), out number2) == false) 
//         {
//             Console.WriteLine("Second number Invalid argument");
//         }

//         switch (operation)
//         {
//             case "sum":
//             Add(number1,number2);
//             break;

//             case "subtract":
//             Subtract(number1,number2);
//             break;

//             case "multiply":
//             Multiply(number1,number2);
//             break;

//             case "divide":
//             Divide(number1,number2);
//             break;

//             default:
//             Console.WriteLine("Invalid operation try again");
//             Calculator();
//             break;
//         }
//     }

//      public static void Main(String[] args)
//     {
//         Calculator();   
//     }
// }