using System;
using System.Threading.Tasks;

namespace FirstProject.day9.ThreadSync {

    class Thread1 {
        public void Task() {
            lock("sl") {
                for(int i=0; i<10; i++) {
                    Console.WriteLine($"TC1 - Task Executed for {i+1} times" + 
                        $"using the Thread Id: {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(1000);
                }
            }
        }
    }

    class Thread2 {
        public void Task() {
            for(int i=0; i<5; i++) {
                Console.WriteLine($"TC2 - Task Executed for {i + 1} times" +
                        $"using the Thread Id: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }

    class Demo {

        static void Main(string[] args) {

            Thread1 tc1 = new Thread1();
            Thread2 tc2 = new Thread2();

            Thread thread1 = new Thread(new ThreadStart(tc1.Task));
            Thread thread2 = new Thread(new ThreadStart(tc1.Task));
            Thread thread3 = new Thread(new ThreadStart(tc2.Task));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

    }
}
