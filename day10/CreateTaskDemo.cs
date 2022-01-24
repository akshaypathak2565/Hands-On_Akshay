using System;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class CreateTaskDemo {
        static void Main(string[] args) {

            Console.WriteLine($"Main method started executing using thread id: {Thread.CurrentThread.ManagedThreadId}");

            // 1st way of creating and starting the task
            Task.Factory.StartNew(() => {
                Console.WriteLine($"First task has been executed using thread id: {Thread.CurrentThread.ManagedThreadId}");
            });

            // 2nd way of creating the task
            var task = new Task(() => {
                Console.WriteLine($"Second task has been executed using thread id: {Thread.CurrentThread.ManagedThreadId}");
            });

            // starting the task
            task.Start();

            Console.WriteLine("Press any key to complete");
            Console.ReadKey();

            Console.WriteLine($"Main method exection completed using thread id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
