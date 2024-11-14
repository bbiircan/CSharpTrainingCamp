using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");

            #region Kategori Ekleme Islemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = localhost; initial catalog = TrainingCampDb; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi");
            #endregion

            #region Urun Ekleme Islemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürünün Adını Giriniz: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklediğiniz Ürünün Fiyatını Giriniz: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = localhost; initial catalog = TrainingCampDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Eklendi");

            #endregion

            #region Urun Listeleme Islemi

            //SqlConnection connection = new SqlConnection("Data Source = localhost; initial catalog = TrainingCampDb; integrated security = true");
            //connection.Open(); //bağlantı açıldı
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //sorgu okundu
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //dataadapter oluşturuldu
            //DataTable dataTable = new DataTable(); //datatable oluşturuldu
            //adapter.Fill(dataTable); // içi dolduruldu

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Urun Silme Islemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = localhost; initial catalog = TrainingCampDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı");

            #endregion

            #region Urun Guncelleme Islemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = localhost; initial catalog = TrainingCampDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId ", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Tamamlandı");

            #endregion

            Console.Read();
        }
    }
}
