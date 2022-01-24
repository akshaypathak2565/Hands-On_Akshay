using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class TaskParallelDemo {
        static long total = 0L;

        static void AddValues() {
            for (int i = 0; i < 1000000; i++) {
                total += i;
            }
        }

        static void SubValues() {
            for (int i = 0; i < 1000000; i++) {
                total -= i;
            }
        }

        static void Main(string[] args) {

            Task task1 = new Task(AddValues);
            Task task2 = new Task(SubValues);

            task1.Start();
            task2.Start();

            Task.WaitAll(new Task[] { task1, task2 });

            Console.WriteLine($"Total Value: {total}");


        }
    }
}
