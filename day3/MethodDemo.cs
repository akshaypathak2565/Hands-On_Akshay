using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.Method {
    class Employee {
        public int empno, deptno;
        public string ename, job;
        public decimal salary;
        public static int totalEmployees;
        public Employee() //Non-Static Constructor (Zero-Arg)
        {
            totalEmployees += 1;
        }
        public void showEmployee() {
            Console.WriteLine($"Employee # :{empno}");
            Console.WriteLine($"Employee Name :{ename}");
            Console.WriteLine($"Salary :{salary}");
            Console.WriteLine($"Department # :{deptno}");
            Console.WriteLine($"Designation :{job}");
            Console.WriteLine("-------------------------");
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
            e1.showEmployee();
            e2.showEmployee();
            e3.showEmployee();
        }

    }
}
