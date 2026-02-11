using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string categoryId;
            //Console.WriteLine("***** C# Database-based product category system *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("1 - Menu category");
            //Console.WriteLine("2 - Menu products");
            //Console.WriteLine("3 - Orders");
            //Console.WriteLine("4 - Exit");
            //Console.WriteLine("-----------------------------");
            //Console.Write("Enter the ID of the category you wish to view: ");
            //categoryId = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source = localhost\\SQLEXPRESS; initial Catalog = SQLcampDb;integrated security = true; ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //connection.Close();

            //foreach (DataRow dataRow in dataTable.Rows) {
            //    foreach (var data in dataRow.ItemArray) { 
            //            Console.Write(data.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
             

            Console.Read();

        }
    }
}
