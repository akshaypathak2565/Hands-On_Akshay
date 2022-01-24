using System;
using System.Threading.Tasks;

namespace FirstProject.day9.MutexThreading {
    class ThreadClass1 {
        public static Mutex mutex = new Mutex();
        public void Task() {
            Console.WriteLine($"Executing Task of ThreadClass1 Started :{ Thread.CurrentThread.Name}");
        mutex.WaitOne();
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"TC1 - Task Executed for {i + 1} times " +
                $"using the Thread ID : {Thread.CurrentThread.Name}");
                Thread.Sleep(1000);
            }
            mutex.ReleaseMutex();
            Console.WriteLine($"Executing Task of ThreadClass1 Completed : { Thread.CurrentThread.Name}");
        }
    }
    class ThreadClass2 {
        public void Task() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"TC2 - Task Executed for {i + 1} times " +
                $"using the Thread ID : {Thread.CurrentThread.Name}");
                Thread.Sleep(1000);
            }
        }
    }

    public class Demo {
        public static void Main(string[] args) {
            ThreadClass1 tc1 = new ThreadClass1();
            ThreadClass2 tc2 = new ThreadClass2();
            Thread thread1 = new Thread(new ThreadStart(tc1.Task));
            thread1.Name = "Thread1";
            Thread thread2 = new Thread(new ThreadStart(tc1.Task));
            thread2.Name = "Thread2";
            Thread thread3 = new Thread(new ThreadStart(tc2.Task));
            thread3.Name = "Thread3";
            thread1.Start();
            thread3.Start();
            thread2.Start();
        }
    }
}
