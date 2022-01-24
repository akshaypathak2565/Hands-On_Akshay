using System;
using System.Threading.Tasks;

namespace FirstProject.day9.ThreadMonitoring {
    
    class ThreadClass {
        static readonly object lockObject = new object();

        public void Task() {
            Console.WriteLine($"Executing Task of ThreadClass1 Started: {Thread.CurrentThread.Name}");
            Monitor.Enter(lockObject);
            Console.WriteLine($"{Thread.CurrentThread.Name} Entered in the Critical Section.");

            for(int i=0; i<5; i++) {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} Exiting the Critical Section.");
            Monitor.Exit(lockObject);
            Console.WriteLine($"Exiting Task of ThreadClass1 Completed:  {Thread.CurrentThread.Name}");
        }
    }

    class Demo {
        static void Main(string[] args) {
            ThreadClass tc = new ThreadClass();

            Thread thread1 = new Thread(new ThreadStart(tc.Task));
            thread1.Name = "Thread1";

            Thread thread2 = new Thread(new ThreadStart(tc.Task));
            thread2.Name = "Thread2";

            thread1.Start();
            thread2.Start();
        }
    }
}
