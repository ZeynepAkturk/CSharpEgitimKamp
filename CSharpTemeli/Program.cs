using System;
using System.Collections.Generic;

//Vira Bismillah


namespace CSharpTemeli
{
    class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            //Console.Write( "Merhaba Dünya");
            //Console.Read(); // konsol ekranını enter dışına basana kadar tut.

            #endregion

            #region Değişkenler
            // String Değişkenler
            string customerName; //camelCase
            customerName = "Zeynep";
            Console.WriteLine(customerName);
            string customerSurname, customerPhone, customerEmail, district, city;
            customerSurname = "Aktürk";
            customerPhone = "+90 500 349 55 61";
            customerEmail = "deneme@gmail.com";
            district = "İlkadım";
            city = "Samsun";
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);

            //Int Değişkenler
            int number = 12;
            Console.WriteLine(number);

            //Double Değişkenler
            double numberDouble = 4.56;
            Console.WriteLine(numberDouble); //double değişken . kullanılarak tanımlanırken konsol ekranında çıktısı virgül olur.
            Console.OutputEncoding = System.Text.Encoding.UTF8; //özel karakterleri konsolda görebilmek için kullandık.
            Console.WriteLine("₺");
            double orangeGram = 3300;
            double orangePrice = 10;
            double orangeTotalPrice = orangeGram * orangePrice;
            Console.WriteLine("Orange price : " + orangeTotalPrice + " ₺");


            //Char Değişkenler
            char symbol = 'a';
            Console.WriteLine(symbol);

            //Klavyeden Veri Girişleri String Değişkenler
            Console.WriteLine("CHARP HAVA YOLLLARI YOLCU BİLGİSİ");
            //ctr+f customer --> passenger
            string passengerName, passengerSurname;
            Console.WriteLine("Yolcu Adı: ");
            passengerName = Console.ReadLine(); //kalvyeden veri girişi
            Console.WriteLine(passengerName);

            //Klavyeden Tam Sayı Girişleri ve Dönüşümler
            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 500;
            tvPrice = 12000;
            int shoesCount, computerCount, tvCount;
            Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz.");
            shoesCount = int.Parse(Console.ReadLine()); //Parse() : dönüşüm işlemi için kullanılır.
            Console.WriteLine("Alınan ayakkabıların ücreti: " + shoesCount * shoePrice);

            //Klavyeden ondalıklı sayı işlemleri
            Console.WriteLine("Lütfen sınav notunuzu giriniz.");
            double examNote = double.Parse(Console.ReadLine());
            Console.WriteLine();





            

            #endregion 


        }
    }
}
