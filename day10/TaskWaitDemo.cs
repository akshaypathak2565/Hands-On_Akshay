using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class TaskWaitDemo {
        static void Main(string[] args) {

            Console.WriteLine($"Main method started executing using thread id: {Thread.CurrentThread.ManagedThreadId}");

            var task1 = Task.Factory.StartNew(() => {
                for (int i = 0; i < 5; i++) {
                    Task.Delay(5000);
                    Console.WriteLine($"First task has been executed using thread id: {Thread.CurrentThread.ManagedThreadId}");
                }
            });

            task1.Wait();

            var task2 = new Task(() => {
                for (int i = 0; i < 3; i++) {
                    Task.Delay(5000);
                    Console.WriteLine($"Second task has been executed using thread id: {Thread.CurrentThread.ManagedThreadId}");
                }
            });

            // starting the task
            task2.Start();
            task2.Wait();

            Console.WriteLine("Press any key to complete");
            Console.ReadKey();

            Console.WriteLine($"Main method exection completed using thread id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
