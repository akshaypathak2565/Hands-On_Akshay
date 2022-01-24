using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {

    class TestDynamic {
        public dynamic MyProperty { get; set; }
    }

    internal class DynamicTypeDemo {
        static void Main(string[] args) {
            dynamic value;
            value = 100;

            Console.WriteLine($"Value = {value}");

            value = "C#";
            Console.WriteLine($"Update value = {value}");

            var td1 = new TestDynamic() { MyProperty = 1000 };
            Console.WriteLine(td1.MyProperty);

            var td2 = new TestDynamic() { MyProperty = "C#" };
            Console.WriteLine(td2.MyProperty);
        }
    }
}
