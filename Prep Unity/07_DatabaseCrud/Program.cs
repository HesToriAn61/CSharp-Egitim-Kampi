using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud--> Create-Read-Update-Delete

            Console.WriteLine("***** MENU ORDER FİX PANEL *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");


            #region Adding New Category

            //Console.Write("Category name you want to add: ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = localhost\\SQLEXPRESS; initial catalog = SQLcampDb; integrated security = true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Adding category is successfull");

            #endregion

            #region Adding New Product

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.Write("Product Name: ");
            //productName = Console.ReadLine();
            //Console.Write("Product Prize: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = localhost\\SQLEXPRESS; initial catalog = SQLcampDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Adding Product is successfull");


            #endregion

            #region Product Listing Process

            //SqlConnection connection = new SqlConnection("Data source = localhost\\SQLEXPRESS; initial Catalog = SQLcampDb; integrated security= true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) {
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();    
            //}

            //connection.Close();


            #endregion

            #region Deleting Product

            //Console.Write("Category name you want to delete: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = localhost\\SQLEXPRESS; initial Catalog= SQLcampDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID = @productID",connection);

            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Deleting product is succesfull");


            #endregion

            #region Uploading Product

            //Console.Write("Product ID: ");
            //int productID = int.Parse(Console.ReadLine());
            //Console.Write("Product Name: ");
            //string productName = Console.ReadLine();
            //Console.Write("Product Price: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = localhost\\SQLEXPRESS; initial Catalog= SQLcampDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice where ProductID = @productID", connection);

            //command.Parameters.AddWithValue("@productID", productID);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Updating is successfull");
                
            #endregion

            Console.Read();
        }
    }
}
