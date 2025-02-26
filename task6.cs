// Task 6: Sum of Any Numbers
// Task: Write a program for numbers sum calculation:
// Write a method that calculates the sum of the numbers in an array.
// Use params in method parameters.
// Read numbers from user input.

// class Program
// {

//     static void SumArray(out int sum,params int[] values)
//     {
//         sum = 0;
//         for (int i = 0; i < values.Length; i++)
//         {
//             sum += values[i];
//         }

//         return ;
//     }
//     public static void Main(string[] args)
//     {
//         int size;
//         Console.WriteLine("Enter array size");
//         while (int.TryParse(Console.ReadLine(), out size) == false)
//         {
//             Console.WriteLine("You enter invalid value");
//         }

//         int[] array = new int[size];
//         Console.WriteLine("Enter elements");
//         for (int i = 0; i < array.Length; i++)
//         {
//             while (int.TryParse(Console.ReadLine(), out array[i]) == false)
//             {
//                 Console.WriteLine("You enter invalid value try again");
//             }
//         }

//         int sum;
//         SumArray(out sum,array);
//         Console.WriteLine($"Sum of array is {sum}");
//     }
// }
