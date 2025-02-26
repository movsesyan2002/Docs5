// // Task 3:  Find the maximum from the numbers
// // Task: Write a program to find max from input numbers array:
// // Write a method to find the maximum value from an array of input numbers.
// // Use ref and params in method parameters.
// // Read numbers from user input.

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter array size");
        
//         int size = 0;
//         while (int.TryParse(Console.ReadLine(), out size) == false)
//         {
//             Console.WriteLine("You enter invalid number try again");
//         }
//         int[] numbers = new int[size] ;

//         Console.WriteLine("Enter array elements");

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             while (int.TryParse(Console.ReadLine(), out numbers[i]) == false)
//             {
//                Console.WriteLine("You enter invalid number for array try again"); 
//             }
//         }   

//         int maximum = 0;
//         FindMax(ref maximum, numbers);
//         Console.WriteLine($"Maximum number of array is {maximum}");
//     }

//     static void FindMax (ref int maxnumber,params int[] numbers)
//     {
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > maxnumber)
//             {
//                 maxnumber = numbers[i];
//             } 
//         }
//     }
// }
