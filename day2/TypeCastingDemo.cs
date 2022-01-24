using System;


namespace FirstProject.day2.TypeCasting {
    class Demo {

        static void Main(string[] args) {

            int i = 10;
            double d = i; // Implicit Typecasting:  Lower Size value assigned to Higher Size Value

            double d1 = 10.5;
            //int i1 = d1; // Error:
            int i1 = (int)d1; // Explicit TypeCasting: Higher Size value assigned to Lower Size Value

            Console.WriteLine($"{i} : {d}\n{i1} : {d1}");

        }

    }
}
