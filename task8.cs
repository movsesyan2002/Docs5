// Task 8: Fibonacci Sequence
// Task: Write a program that returns n-th number from Fibonacci Sequence:
// Write a recursive method that returns the n-th number in Fibonacci Sequence.
// Call it with a user-provided n.

// class Program
// {
//     static int Fibbonacci(int index){
//         if (index == 0)
//         {
//             return 0;
//         }

//         if (index == 1)
//         {
//             return 1;
//         }

//         return Fibbonacci(index - 1) + Fibbonacci(index - 2);
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter Fibbonacci inde and I take you number");
//         int index;
//         int.TryParse(Console.ReadLine(), out index);
//         int value = Fibbonacci(index);
//         Console.WriteLine($"This {index} index value is {value}");
//     }
// }