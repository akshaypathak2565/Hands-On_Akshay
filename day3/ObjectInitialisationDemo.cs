using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.ObjectInitialisation {

    class Employee {
        public int empno, deptno;
        public string ename, job;
        public decimal salary;
        public static int totalEmployees;
        public Employee() {
            totalEmployees += 1;
        }
    }


    class Demo {
        public static void Main(string[] args) {
            Employee e1 = new Employee() {
                empno = 101,
                ename = "Sekhar",
                salary = 10000,
                deptno = 10,
                job = "SALESMAN"
            };
            Employee e2 = new Employee() {
                empno = 102,
                ename = "Srinivasan",
                job = "SALESMAN"
            };
            Employee e3 = new Employee() {
                empno = 103,
                ename = "Sri",
                salary = 10000,
                job = "SALESMAN"
            };
            Console.WriteLine($"Total Employees :{Employee.totalEmployees}");
            Console.WriteLine($"E1 : {e1.empno}, {e1.ename}, {e1.salary}, {e1.deptno}, { e1.job}");
            Console.WriteLine($"E2 : {e2.empno}, {e2.ename}, {e2.salary}, {e2.deptno}, { e2.job}");
            Console.WriteLine($"E3 : {e3.empno}, {e3.ename}, {e3.salary}, {e3.deptno}, { e3.job} ");
        }
    }
}
