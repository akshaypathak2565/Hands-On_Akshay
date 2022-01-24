using System;
using System.Text;

namespace FirstProject.day6.StringBuilderDemo {

    class Demo {
        static void Main(string[] args) {

            string s1 = "C#";

            Console.WriteLine($"Value of s1 = {s1}");
            Console.WriteLine($"Address of s1 = {s1.GetHashCode()}");

            s1 += ".NET";
            Console.WriteLine($"Value of s1 = {s1}");
            Console.WriteLine($"Address of s1 = {s1.GetHashCode()}");

            s1 += " - Rocks";
            Console.WriteLine($"Value of s1 = {s1}");
            Console.WriteLine($"Address of s1 = {s1.GetHashCode()}");

            Console.WriteLine("------------------------");

            // String builder
            StringBuilder sb = new StringBuilder("C#");
            Console.WriteLine($"Value of sb = {sb}");
            Console.WriteLine($"Address of sb = {sb.GetHashCode()}");

            sb.Append(".NET");
            Console.WriteLine($"Value of sb = {sb}");
            Console.WriteLine($"Address of sb = {sb.GetHashCode()}");

            sb.Append(" - Rocks");
            Console.WriteLine($"Value of sb = {sb}");
            Console.WriteLine($"Address of sb = {sb.GetHashCode()}");



        }
    }
}
