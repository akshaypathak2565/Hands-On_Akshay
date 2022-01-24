using System;
using System.Collections;

namespace FirstProject.day8.ArrayListDemo {
    class Demo {
        static void Main(string[] args) {
            ArrayList list = new ArrayList();
            list.Add(123);
            list.Add("Harsh");
            list.Add(false);
            list.Add(12.03);

            foreach(var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine(nameof(List<int>));
            Console.WriteLine(nameof(list));
        }
    }
}
