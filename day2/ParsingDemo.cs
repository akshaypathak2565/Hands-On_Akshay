using System;

namespace FirstProject.day2.Parsing {
    internal class ParsingDemo {

        static void Main(string[] args) {

            int empno;
            string ename;
            decimal salary;
            DateTime hireDate;
            Console.Write("Enter Employee # :");
            empno = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name :");
            ename = Console.ReadLine();
            Console.Write("Salary :");
            salary = decimal.Parse(Console.ReadLine());
            hireDate = DateTime.Now; //Assigns current date and time
            Console.WriteLine($"Employe Number : {empno}\nEmployee Name : {ename}\n" +
            $"Salary : {salary}\nHiredate : {hireDate}");


        }
    }
}
