using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {

    internal class TaskLockingDemo {
        static long total = 0;

        static void AddValues() {
            for (int i = 0; i < 1000000; i++) {
                lock("task") {
                    total += i;
                }
            }
        }

        static void SubValues() {
            for (int i = 0; i < 1000000; i++) {
                lock("task") {
                    total -= i;
                }
            }
        }

        static void Main(string[] args) {

            var task1 = new Task(AddValues);
            var task2 = new Task(SubValues);

            task1.Start();
            task2.Start();

            Task.WaitAll(new Task[] { task1, task2 });

            Console.WriteLine($"Total Value = {total}");

        }

    }
}
