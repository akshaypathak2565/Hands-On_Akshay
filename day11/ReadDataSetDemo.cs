using System;
using System.Data;
//using System.Windows.Forms;
using System.IO;

namespace FirstProject.day11 {
    internal class ReadDataSetDemo {
        static void Main(string[] args) {

            var filePath = "Departments.csv";

            DataSet ds = new DataSet();
            ds.Tables.Add("Departments");

            StreamReader sr = new StreamReader(filePath);
            string colHeader = sr.ReadLine();
            string[] columns = colHeader.Split(',');

            foreach (var col in columns) {
                ds.Tables["Departments"].Columns.Add(col);
                Console.Write($"{col}\t");
            }

            Console.WriteLine();

            string dataRow = sr.ReadLine();
            while (dataRow != null) {

                string[] row = dataRow.Split(',');
                foreach (string value in row) {
                    Console.Write($"{value}\t");
                }
                Console.WriteLine();
                ds.Tables["Departments"].Rows.Add(row);

                dataRow = sr.ReadLine();
            }

            sr.Close();

            //var winForm = new Form();
            //winForm.Text = "Departments";

            //var dataGrid = new DataGrid();
            //dataGrid.Dock = DockStyle.Fill;
            //dataGrid.DataSource = ds.Tables["Departments"];

            //winForm.Controls.Add(dataGrid);
            //Application.Run(winForm);
        }
    }
}
