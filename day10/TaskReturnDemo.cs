using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class TaskReturnDemo {
        static void Main(string[] args) {

            var task1 = new Task<string>(() => {
                Console.WriteLine($"Task 2 running with thread id: {Thread.CurrentThread.ManagedThreadId}");
                return "Task1 Result";
            });

            Task<string> task2 = new Task<string>(() => {
                Console.WriteLine($"Task 2 running with thread id: {Thread.CurrentThread.ManagedThreadId}");
                return "Task2 Result";
            });

            task2.Start();

            var result1 = task1.Result;
            var result2 = task2.Result;
            Console.WriteLine($"Task 1 result: {result1}");
            Console.WriteLine($"Task 2 result: {result2}");

        }
    }
}
