// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Double Değişkenler
//Double Değişkenler
double numberDouble = 4.56;
Console.WriteLine(numberDouble); //double değişken . kullanılarak tanımlanırken konsol ekranında çıktısı virgül olur.
Console.OutputEncoding = System.Text.Encoding.UTF8; //özel karakterleri konsolda görebilmek için kullandık.
Console.WriteLine("₺");
double orangeGram = 3300;
double orangePrice = 10;
double orangeTotalPrice = orangeGram * orangePrice;
Console.WriteLine("Orange price : " + orangeTotalPrice + " ₺");
#endregion


#region Char Değişkenler
//Char Değişkenler
char symbol = 'a';
Console.WriteLine(symbol);
#endregion


#region Klavyeden Veri Girişleri String Değişkenleri
//Klavyeden Veri Girişleri String Değişkenler
Console.WriteLine("CSHARP HAVA YOLLLARI YOLCU BİLGİSİ");
//ctr+f customer --> passenger
string passengerName, passengerSurname;
Console.WriteLine("Yolcu Adı: ");
passengerName = Console.ReadLine(); //kalvyeden veri girişi
Console.WriteLine(passengerName);

#endregion 


#region Klavyeden Tam Sayı Girişleri ve Dönüşümler
int shoePrice, computerPrice, chairPrice, tvPrice;
shoePrice = 1000;
computerPrice = 20000;
chairPrice = 500;
tvPrice = 12000;
int shoesCount, computerCount, tvCount;
Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz.");
shoesCount = int.Parse(Console.ReadLine()); //Parse() : dönüşüm işlemi için kullanılır.
Console.WriteLine("Alınan ayakkabıların ücreti: " + shoesCount * shoePrice);

#endregion


#region Klavyeden ondalıklı sayı işlemleri
Console.WriteLine("Lütfen sınav notunuzu giriniz.");
double examNote = double.Parse(Console.ReadLine());
Console.WriteLine();

#endregion


#region Klavyeden Karakter Girişleri 
char gender;
Console.Write("Lütfen cinsiyeti seçiniz.");
gender = char.Parse(Console.ReadLine());

Console.WriteLine("Seçtiğiniz cinsiyet :"+ gender);

#endregion

