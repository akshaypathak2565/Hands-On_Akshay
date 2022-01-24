using System;

//A nameOf expression returns the name of a variable, type or member as the string constant.

namespace FirstProject.day6.NameOfProperty {
    internal class Demo {

        static void Main(string[] args) {
            string str = "C#";
            Console.WriteLine("str got modifed");
            Console.WriteLine($"{nameof(str)} got modifed");

            Console.WriteLine(nameof(List<int>));

            var numbers = new List<int> { 1, 2, 3 };

            Console.WriteLine(nameof(numbers));
            Console.WriteLine(nameof(numbers.Count));
        }
    }
}
