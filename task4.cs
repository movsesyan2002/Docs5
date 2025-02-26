// Task 4: Convert Temperature
// Task: Write a program for temperature conversion:
// Write a method that converts Celsius to Fahrenheit and Kelvin.
// Use ref and out in method parameters.
// Call it with a user-provided Celsius value.

// class Program {

    
//     public static void Main(string[] args) {   
//         Console.WriteLine("Enter a celsius value");
//         int celsius = 0;
//         while (int.TryParse(Console.ReadLine(), out celsius) == false) {
//             Console.WriteLine("You enter wrong value try again");
//         }

//         float conv;
//         TemperatureCalculator(ref celsius, out conv);
//         Console.WriteLine($"Before convert {celsius}\nConverted is {conv}");
//     }

//     public static void TemperatureCalculator(ref int temperature, out float converted) {
//         Console.WriteLine("Which calculation type do you want Kelvin or Farenheit");
//         string? choice = Console.ReadLine();
//         if (string.Compare(choice, "kelvin", true) == 0)
//         {
//             converted = ConvertKelvin(temperature);
//             return;
//         }

//         else if (string.Compare(choice, "farenheit",true) == 0)
//         {
//             converted = ConvertFarenheit(temperature);
//             return;
//         }

//         else
//         {   
//             Console.WriteLine("The input is wrong");
//             converted = (float)temperature;
//         }
//     }

//     public static float ConvertKelvin(int ctemperature) {
//         float converted = (ctemperature * 9/5) + 32 ;
//         return converted;
//     }

//     public static float ConvertFarenheit(int ctemperature) {
//         float converted = ctemperature + 273.13f ;
//         return converted;
//     }
// }

