using System;

namespace FirstProject.day7.SimpleDelegate
{
    public delegate int calculate(int x, int y);

    public class Calculator
    {
        public int add(int a, int b)
        {
            Console.WriteLine($"Adding {a} and {b}");
            return a + b;
        }

        public int multiply(int a, int b)
        {
            Console.WriteLine($"Multiplying {a} and {b}");
            return a * b;
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            var cal = new Calculator();
            //Console.WriteLine(cal.add(10,20));

            var add = new calculate(cal.add);
            var multiply = new calculate(cal.multiply);

            Console.WriteLine(add(10,20));
            Console.WriteLine(add.Invoke(30,50));
            Console.WriteLine(multiply(10,20));

            Console.WriteLine("-------------------");

            // MutliCasting Delegate
            calculate multDel = cal.multiply;
            multDel += cal.add;

            Console.WriteLine(multDel.Invoke(50,60));
        }
    }
}
