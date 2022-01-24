using System;

class Student {
    public int studentId;
    public string name;
    public string course;
    public static int totalStudents;

}

class Test {
    public static void Main(string[] args) {
        Student s1 = new Student();
        s1.studentId = 101;
        s1.name = "Harsh Kumar";
        s1.course = "DotNet";

        Student.totalStudents = 20;

        Console.WriteLine(s1.studentId);
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.course);

        Student s2 = new Student();
        s2.studentId = 103;
        s2.name = "John Deo";
        s2.course = "DotNet";

        Console.WriteLine(s2.studentId);
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.course);

        String str = "Hello";
        greeting(ref str);

        Console.WriteLine(str);

    }

    public static void greeting(ref String s) {
        Console.WriteLine(s);
        s = "World";
    }


}