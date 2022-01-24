using System;

namespace FirstProject.day7.LocalFunction {
    class Demo {
        static void Main(string[] args) {
            int no1 = 10;
            int no2 = 20;

            // Local Function
            int add(int n1, int n2) {
                return n1 + n2;
            }

            int result = add(no1, no2);

            Console.WriteLine($"Sum of {no1} and {no2} = {result}");
        }
    }
}
