using System;
using System.Threading.Tasks;

namespace FirstProject.day9.ThreadPoolClass {
    class Demo {

        static void Main(string[] args) {

            for(int i=0; i<1000; i++) {

                ThreadPool.SetMinThreads(16, 10);
                ThreadPool.SetMaxThreads(32, 10);

                ThreadPool.QueueUserWorkItem(DoSomeWork, i);

                while(ThreadPool.PendingWorkItemCount != 0) {
                    Console.WriteLine($"Threads = {ThreadPool.ThreadCount}");
                    Console.WriteLine($"Completed = {ThreadPool.CompletedWorkItemCount}");
                    Console.WriteLine($"Pending = {ThreadPool.PendingWorkItemCount}");

                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("--------------------");
                }

            }

        }

        static void DoSomeWork(Object o) {
            // Some Important Work
            Console.WriteLine($"Important Executed Successfully by Thread Id :  {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(100);
        }

    }
}
