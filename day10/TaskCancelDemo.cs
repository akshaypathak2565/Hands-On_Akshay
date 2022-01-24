using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class TaskCancelDemo {
        static void Main(string[] args) {

            var cts = new CancellationTokenSource();

            var task1 = Task.Factory.StartNew(() => {

                for (int i = 0; i < 100; i++) {
                    if (cts.IsCancellationRequested) {
                        Console.WriteLine("Task canceled.");
                        break;
                    }
                    Console.WriteLine($"Task Executed for {i + 1} times.");
                    Thread.Sleep(1000);
                }
            }, cts.Token);

            //task1.Start();
            Console.WriteLine("Press any key to cancel the task.");
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine("Program executed completed...");

        }
    }
}
