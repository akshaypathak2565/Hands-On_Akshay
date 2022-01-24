using System;

// Dictonary

namespace FirstProject.day8 {
    internal class DictonaryDemo {

        static void Main(string[] args) {

            var dayOfWeek = new Dictionary<int, string>();

            // First way of adding element
            dayOfWeek.Add(1, "Moday");

            // Second way
            dayOfWeek[2] = "Tuesday";
            dayOfWeek[3] = "Wednesday";
            dayOfWeek[5] = "Thrusday";
            dayOfWeek[6] = "Friday";
            dayOfWeek[7] = "Saturday";

            foreach(KeyValuePair<int, string> day in dayOfWeek) {
                Console.WriteLine($"{day.Key} : {day.Value}");
            }

            Console.WriteLine("----------------------");


            // Removing an Item
            dayOfWeek.Remove(2);

            foreach(var day in dayOfWeek) {
                Console.WriteLine($"{day.Key} : {day.Value}");
            }
        }
    }
}
