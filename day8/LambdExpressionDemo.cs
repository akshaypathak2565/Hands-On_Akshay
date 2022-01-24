using System;

// Lambda Expression
namespace FirstProject.day8.LambdExpression {
    class Demo {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(4);

            // Lambda Expression
            var squareNumbers = numbers.Select(no => no * no);

            Console.WriteLine("Square Numbers:");
            foreach(var no in squareNumbers) {
                Console.WriteLine(no);
            }

            Console.WriteLine("----------------");

            var evenNumbers = numbers.FindAll(no => no % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var no in evenNumbers) {
                Console.WriteLine(no);
            }
        }
    }
}
