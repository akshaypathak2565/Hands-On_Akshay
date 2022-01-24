using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day10 {
    internal class TaskWithExceptionHandling {
        static void Main(string[] args) {

            var task1 = new Task(() => {
                for (int i = 0; i < 10; i++) {
                    if(i > 5) {
                        // throwing new Exception
                        throw new Exception("Request Timed Out.");
                    }
                    Console.WriteLine($"Task Executed for {i+1}");
                    Thread.Sleep(1000);
                }
            });


            // Handling Exception
            try {
                task1.Start();
                task1.Wait();
            } catch (AggregateException ae) {
                ae.Handle(e => {
                    Console.WriteLine($"Exception Raised {e.Message}");
                    return true;
                });
            } catch (Exception e) {
                Console.WriteLine($"Error : {e.Message}");
            }

            Console.WriteLine("Task Execution Completed.");

        }
    }
}
