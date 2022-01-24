using System;

namespace FirstProject.day8.FunDelegate {

    // Custom delegate : It can refer to the address of any function which 
    // accepts string as input and returns string as an output
    // delegate string ConvertMethod(string str);

    class Demo {
        static void Main(string[] args) {
            // ConvertMethod convert = new ConvertMethod(UpperCaseString);

            Func<string, string> convert = new Func<string, string>(UpperCaseString);
            // or

            Func<int, int, string> add = addNum;
            string name = "harsh kumar";
            Console.WriteLine(convert(name));
            Console.WriteLine(add(10,20));

        }

        public static string UpperCaseString(string str) {
            return str.ToUpper();
        }

        public static string addNum(int n1, int n2) {
            return $"{n1} + {n2} = {n1 + n2}";
        }

    }
}
