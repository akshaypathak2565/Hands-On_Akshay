using System;

namespace FirstProject.Nullablility {
    class Employee {
        public int Empno {
            get;
            set;
        }
        public string EName {
            get;
            set;
        }
        public decimal Salary {
            get;
            set;
        }
        public string Job {
            get;
            set;
        }
        public decimal? Commission {
            get;
            set;
        }

    }

    class Company {
        public List<Employee> Employees;

        public Company() {
            Employees = new List<Employee>() {

        new Employee() {
            Empno = 101, EName = "First Emp", Job = "Salesman", Salary = 10000, Commission = 500
          },
          new Employee() {
            Empno = 102, EName = "Second Emp", Job = "Developer", Salary = 50000, Commission = null
          },
          new Employee() {
            Empno = 103, EName = "Third Emp", Job = "Salesman", Salary = 12000, Commission = 300
          }
      };

        }
    }

    class Demo {
        static void Main(string[] args) {
            Company company = new Company();
            var emp = company.Employees.SingleOrDefault(e => e.Empno == 101);

            decimal? totalSalary = emp.Salary + emp.Commission;
            totalSalary ??= emp.Salary;

        }
    }
}