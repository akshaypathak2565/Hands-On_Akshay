using System;

namespace FirstProject.day2.StaticAndNonStatic {
    class Test {
        public int ns; //Non-Static Member
        public static int s; //Static Member
    }

    class Demo {

        static void Main(string[] args) {
            Test.s = 100;
            Test t1 = new Test();
            t1.ns = 1000;
            Test t2 = new Test();
            t2.ns = 2000;
            Console.WriteLine($"{Test.s}\t{t1.ns}\t{t2.ns}");

        }

    }
}
