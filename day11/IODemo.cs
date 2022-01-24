using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day11 {
    internal class IODemo {
        static void Main(string[] args) {
            string path = @".\sample.txt";

            if(File.Exists(path)) {
                //In case file exists: reads the file contents

                StreamReader sr = new StreamReader(path);
                var contents = sr.ReadToEnd();
                Console.WriteLine($"File Content:\n{contents}");

                sr.Close();


            } else {
                // In case if file not exists: creates new file write
                // information

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Hello C#, this is IO program");

                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(sb.ToString());

                sw.Flush();
                sw.Close();

                Console.WriteLine("File Created.");
            }
        }
    }
}
