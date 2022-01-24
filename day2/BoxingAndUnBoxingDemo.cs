using System;

namespace FirstProject.day2.BoxingAndUnBoxing {
    class Demo {
        static void Main(string[] args) {

            int i = 10; // value type member
            object o; // reference type member

            int j = i; // Assignment
            o = j; // Boxing

            //int k = o;  // Error
            int k = (int)o; // UnBoxing

            //Console.WriteLine("{0},{1},{2},{3}",i,o,j,k); supported from C# 1.0
            Console.WriteLine($"{i},{o},{j},{k}"); //String Interpolation supported from C# 6.0

        }
    }
}
