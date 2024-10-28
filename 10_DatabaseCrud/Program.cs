using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Eklemek istediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            //    " initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz olarak sorguyu çalıştırır.
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("Ürün adı :");
            //productName = Console.ReadLine();
            //Console.WriteLine("Ürün Fiyatı :");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            //" initial catalog=EgitimKampiDb; integrated security=true");
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //connection.Open();
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı.");



            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            //" initial catalog=EgitimKampiDb; integrated security=true");
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //connection.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable(); //bellekte tablo tutulmasını sağlar.
            //adapter.Fill(dataTable);
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silinecek Ürün Id:");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            //" initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Ürün başarılı bir şekilde silindi.");
            //connection.Close();

            //connection.Close();
            #endregion

            #region Ürün Güncelleme İşlemi

            Console.WriteLine("Güncellenecek ürün id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek ürün isim: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Güncellenecek ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

             SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            " initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme başarılı.");
            #endregion
            Console.Read();


        }
    }
}
