using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day8.ListCollection
{
    internal class Demo {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();
            numbers.Add(40);
            numbers.Insert(1, 20);


            numbers.ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\n-------------------");
            numbers.Remove(1);
            numbers.ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\n-------------------");

            var less30 = from no in numbers where no < 30 select no;

            foreach(int i in less30) {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n-------------------");

            var employees = new EmployeeService().GetEmployees();

            IEnumerable<Employee> allEmployees = from emp in employees
                                                 where emp.DeptNo == 10 select emp;

        }
    }
}
