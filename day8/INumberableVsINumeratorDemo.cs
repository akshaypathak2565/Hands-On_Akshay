using System;

namespace FirstProject.day8.INumberableVsINumerator {
    internal class Demo {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();
            for(int i=1; i<10; i++) {
                numbers.Add(i);
            }

            // INumberable

            IEnumerable<int> numerable = numbers;

            foreach(int num in numerable) {
                Console.Write(num + ", ");
            }

            Console.WriteLine("\n--------------");

            // INumerator
            IEnumerator<int> numerator = numbers.GetEnumerator();

            while(numerator.MoveNext()) {
                Console.Write(numerator.Current + " ");
            }

        }
    }
}
