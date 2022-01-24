using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.OptionalParameters {

    class Calculator {
        public int add(int no1, int no2, int no3 = 0, int no4 = 0, int no5 = 0) {
            return no1 + no2 + no3 + no4 + no5;
        }
    }

    class Demo {
        public static void Main(string[] args) {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.add(10, 20));
            Console.WriteLine(calc.add(10, 20, 30));
            Console.WriteLine(calc.add(10, 20, 30, 40));
            Console.WriteLine(calc.add(10, 20, 30, 40, 50));
        }

    }
}
