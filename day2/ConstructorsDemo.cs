using System;

namespace FirstProject.day2.Constructors {

    class Department {
        public int deptno;
        public string dname, loc;
        public static int totalDepartments;

        // Static Constructor
        static Department() {
            totalDepartments = 0;
        }

        // Non-Static Constructor
        public Department(int dno, string dname, string loc) {
            deptno = dno;
            this.dname = dname;
            this.loc = loc;
            totalDepartments += 1;
        }
    }


    class Demo {
        public static void Main(string[] args) {
            Department d1 = new Department(10, "SALES", "HYD");
            Department d2 = new Department(20, "DEVELOPMENT", "BLR");
            Console.WriteLine($"Total Departments : {Department.totalDepartments}");
            Console.WriteLine($"D1 : {d1.deptno}, {d1.dname}, {d1.loc} ");
            Console.WriteLine($"D2 : {d2.deptno}, {d2.dname}, {d2.loc} ");
        }
    }
}
