// Task 10:  Find the Longest Word
// Task: Write a program to find the longest word from the input words array:
// Write a method that returns the longest word from the input words array.
// Use params in method parameters.
// Call it with a user-provided words array.


// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Please enter word and I take you longest word");
//         Console.WriteLine("How many words do you want?");
//         int wordsize = 0;
//         while (int.TryParse(Console.ReadLine(), out wordsize) == false)
//         {
//             Console.WriteLine("Please enter non invalid value");
//         }

//         string[] words = new string[wordsize];
//         int index = 0;
//         Console.WriteLine("Please enter words");
//         for (int i = 0; i < words.Length; i++)
//         {
//             words[i] = Console.ReadLine();   
//         }

//         string longest = LongestWord(ref index,words);

//         Console.WriteLine($"The longest word is {longest}");
//     }

//     static string LongestWord(ref int index,params string[] values)
//     {
//         int max = 0;
//         for (int i = 0; i < values.Length; i++)
//         {
//             if (max < values[i].Length)
//             {
//                 index = i;
//                 max = values[i].Length;
//             }
//         }

//         return values[index];
//     }
// }