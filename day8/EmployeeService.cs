using System;

namespace FirstProject.day8 {
    public class EmployeeService {

        public List<Employee> GetEmployees() {

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() {
                Empno = 101,
                EName = "First",
                Salary = 10000,
                DeptNo = 10
            });

            employees.Add(new Employee() {
                Empno = 102,
                EName = "Second",
                Salary = 12000,
                DeptNo = 6
            });

            employees.Add(new Employee() {
                Empno = 103,
                EName = "Third",
                Salary = 15000,
                DeptNo = 4
            });

            employees.Add(new Employee() {
                Empno = 103,
                EName = "Fourth",
                Salary = 15000,
                DeptNo = 10
            });


            return employees;

        }

    }
}
