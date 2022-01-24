using System;

// Tuples can be used for returning multiple values.

namespace FirstProject.day6.TuplesDemo {
    class Demo {

        public static Tuple<int, int, string> GetStudentReport(int m1, int m2, int m3) {

            int total = m1 + m2 + m3;
            var avg = total / 3;
            var result = (m1 < 60 || m2 < 60 || m3 < 60) ? "Fail" : "Pass";
            return Tuple.Create(total, avg, result);

        }

        static void Main(string[] args) {

            var report = GetStudentReport(80, 70, 55);
            Console.WriteLine($"Total : {report.Item1}");
            Console.WriteLine($"Average : {report.Item2}");
            Console.WriteLine($"Result : {report.Item3}");

        }

    }
}
