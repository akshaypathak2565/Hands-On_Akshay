using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {

    class VarTesting {
        //var s; Error : we cannot use var keyword other than local variable
        //public var no { get; set; } = 100; Error

        public int result (int n) {
            var square = n * n;
            return square;
        }
    }
    internal class VarTypeDemo {
        static void Main(string[] args) {
            var no = 100;
            int num = 100;

            //var s; Error : Implicitly typed variable has to be defined by initializer
            //s = "C#";
            //num = "C#";

            var res = new VarTesting().result(5);
            Console.WriteLine(res);
        }
    }
}
