using System;

namespace FirstProject.Dictonary {

    class Demo {
        static void Main(string[] args) {
            // With Index initalizer
            Dictionary<int, string> Days = new Dictionary<int, string>() {
                [1] = "Monday",
                [2] = "Tuesday",
                [3] = "Wednesday",
                [4] = "Thrusday",
                [5] = "Friday",
                [6] = "Saturday",
                [7] = "Sunday"
            };

            // Without Index initalizer
            Dictionary<int, string> months = new Dictionary<int, string>() {
                {1, "Jan"},
                {2, "Feb" },
                {3, "Mar" },
                {4, "Apr" },
                {5, "May" },
                {6, "Jun" },
                {7, "Jul" },
                {8, "Aug" },
                {9, "Sep" },
                {10, "Oct" },
                {11, "Nov" },
                {12, "Dec" }
            };

            var day = Days[3];

            Console.WriteLine($"Selected Day {day}");

            months.TryGetValue(5, out var month);
            Console.WriteLine(month);

            foreach(var val in months) {
                Console.WriteLine(val.Value);
            }

        }
    }
}
