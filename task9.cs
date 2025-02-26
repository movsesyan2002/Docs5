// Task 9: Time Converter
// Task: Write a program that converts seconds to time:
// Write a method that converts totalSeconds into hours, minutes, and seconds.
// Use ref and out in method parameters.
// Call it with a user-provided totalSeconds.


// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Please enter second");
//         int second;
//         while (int.TryParse(Console.ReadLine(), out second) == false)
//         {
//             Console.WriteLine("Dear inputter, you have entered an incorrect value try again");    
//         }

//         int hours;
//         int minutes;
//         int seconds;

//         TimeConverter(second, out hours, out minutes, out seconds);

//         Console.WriteLine($"{second} is {hours} hours {minutes} minutes {seconds} seconds");
        
//     }

//     static void TimeConverter( int second, out int hours, out int minutes, out int seconds) {
//         hours = second / 3600;
//         second %= 3600;
//         minutes = second / 60;
//         second %= 60;
//         seconds = second % 60;
//     }

// }