using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day7.ExceptionHandling {
    class Demo {

        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            try {
                float res = a / b;
                Console.WriteLine($"Result = {res}");
            } catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Completed...");
            }

        }

    }
}
