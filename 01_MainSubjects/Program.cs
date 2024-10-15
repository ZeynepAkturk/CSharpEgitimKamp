// See https://aka.ms/new-console-template for more information



#region YazdırmaKomutları
Console.Write("Merhaba Dünya");
Console.Read(); // konsol ekranını enter dışına basana kadar tut.

#endregion

#region  String Değişkenler

string customerName; //camelCase
customerName = "Z*****";
Console.WriteLine(customerName);
string customerSurname, customerPhone, customerEmail, district, city;
customerSurname = "A*****";
customerPhone = "+90 *** *** ** **";
customerEmail = "********@gmail.com";
district = "******";
city = "S*****";
Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);


#endregion

#region Int Değişkenler
//int değişken tanımlama
int number = 12;
Console.WriteLine(number);

// RESTORAN ÖRNEĞİ 

int hamburgerPrice = 4300;
int cakePrice = 35 ;
int friesPrice = 10 ;

Console.WriteLine("***** Restoran Menü Fiyatı*****");
Console.WriteLine();
Console.WriteLine("-----Hamburger : " + hamburgerPrice + " TL");
Console.WriteLine("-----Kek : " + cakePrice + " TL");
Console.WriteLine("-----Kızartma : " + friesPrice + " TL");
Console.WriteLine();

int hamburgerCount=3;
int cakeCount=2;
int friesCount=1;

int totalHamburgerPrice=hamburgerCount*hamburgerPrice;
int totalCakePrice = cakeCount * cakePrice;
int totalFiresPrice = friesCount * friesPrice;

Console.WriteLine("***** Restoran Menü Fiyatı*****");
Console.WriteLine("Hamburger Tutarı : "+ totalHamburgerPrice + " TL");
Console.WriteLine("Kek Tutarı : " + totalCakePrice+" TL");
Console.WriteLine("Kızartma Tutarı : " + totalFiresPrice + " TL");


#endregion