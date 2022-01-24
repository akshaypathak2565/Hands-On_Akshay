using System;

// Open-Closed Principle

namespace FirstProject.day12.designPrinciples.OCP {

    public class Loggers {
        public void WriteLogToSystem(string msg) {
            Console.WriteLine($"Log Message to System: {msg}");
        }
    }

    public class ErrorLogger : Loggers {
        public void WriteLogToFile(string msg) {
            Console.WriteLine($"Log Message to File: {msg}");
        }

        public void WriteLogToDB(string msg) {
            Console.WriteLine($"Log Message to DB: {msg}");
        }
    }

    internal class Demo {
        static void Main(string[] args) {
            var err = new ErrorLogger();
            err.WriteLogToSystem("System Error");
            err.WriteLogToFile("File Error");
            err.WriteLogToDB("DB Error");
        }
    }
}
