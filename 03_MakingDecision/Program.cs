
// See https://aka.ms/new-console-template for more information


#region If Else

//örnek 1 : If-Else kullanımı
//Console.WriteLine("Lütfen şifreyi giriniz:");
//string password;
//password = Console.ReadLine();
//if(password=="abcd")
//{
//    Console.WriteLine("Şifre doğru.");
//}
//else
//{
//    Console.WriteLine("şifre yanlış");
//}

//örnek 2: If-Else kullanımı

//string capital, country;
//Console.Write("Başkenti giriniz :");
//capital = Console.ReadLine();

//Console.WriteLine("Ülkeyi giriniz:");
//country = Console.ReadLine();

//if(capital=="Ankara" & country=="Türkiye")
//{
//    Console.WriteLine("veriler doğrulandı.");
//}
//else
//{
//    Console.WriteLine("hatalı bilgi");
//}

//örnek 3: If-Else kullanımı
//int exam1, exam2, exam3, average;
//string result="geçerli bir değer değil";
//Console.WriteLine("Sınav1:");
//exam1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Sınav2:");
//exam2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Sınav3:");
//exam3 = int.Parse(Console.ReadLine());

//average = (exam1 + exam2 + exam3) / 3;
//Console.WriteLine("Sınavların ortalaması: "+ average);

//if(average>0 &average<=50)
//{
//    result = "Sonuç vasat";
//}
//if(average>50 & average<=70)
//{
//    result = "Sonuç iyi";
//}
//if(average>70 & average<=84)
//{
//    result = "Sonuç iyi";
//}
//if (average > 84 )
//{
//    result = "Sonuç çok iyi";
//}

//Console.WriteLine(result);


#endregion

#region Mod İşlemleri

//int number;
//number = 26;
//int result = number % 5;
//Console.WriteLine(result);

//Örnek 1 : Mod alma işlemleri

//Console.WriteLine("Lütfen 1.sayıyı giriniz");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen 2.sayıyı giriniz");
//int number2 = int.Parse(Console.ReadLine());

//int result = number1 % number2;
//Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);


//Örnek 2 : Sayının çift mi tek mi olduğunu belirleme

//Console.WriteLine("Bir sayı giriniz.:");
//int number = int.Parse(Console.ReadLine());
//if(number%2==0)
//{
//    Console.WriteLine("Girilen sayı çifttir.");
//}
//else
//{
//    Console.WriteLine("Girilen sayı tektir.");
//}

#endregion

#region char değişkeni kullanılarak kontrol örneği
//Örnek 3 : Takım kontrolü örneği
//char team;
//Console.WriteLine("Lütfen takım sembolünü giriniz.");
//team = char.Parse(Console.ReadLine());
//if(team=='t'| team=='T')
//{
//    Console.WriteLine("Trabzonspor");
//}
//if (team == 'b' | team == 'B')
//{
//    Console.WriteLine("Beşiktaş");
//}
//if (team == 'g' | team == 'G')
//{
//    Console.WriteLine("Galatasaray");
//}

#endregion

#region Örnek Proje Uygulaması
//Console.WriteLine("****** C# Eğitim Kampı Restoran *****");
//Console.WriteLine("---------------------------------");
//Console.WriteLine("1. Ana Yemekler");
//Console.WriteLine("2. Çorbalar");
//Console.WriteLine("3. Pizzalar");
//Console.WriteLine("4. İçecekler");
//Console.WriteLine("5. Tatlılar");
//Console.WriteLine("---------------------------------");

//string menuItem;
//Console.WriteLine("Detayını görmek istdiğiniz menü seçimi: ");
//menuItem = Console.ReadLine();
//if(menuItem=="1")
//{
//    Console.WriteLine("-------Ana Yemekler---------");
//    Console.WriteLine("1. Köri Soslu Tavuk");
//    Console.WriteLine("2. Kızartma Tabağı");
//    Console.WriteLine("3. Fasulye Pilav");
//}
//if (menuItem == "2")
//{
//    Console.WriteLine("-------Çorbalar---------");
//    Console.WriteLine("1. Ezogelin Çorbası");
//    Console.WriteLine("2. Mercimek Çorbası");
//    Console.WriteLine("3. Yayla Çorbası");
//}
//if (menuItem == "3")
//{
//    Console.WriteLine("-------Pizzalar---------");
//    Console.WriteLine("1. Akdeniz Pizza");
//    Console.WriteLine("2. Margaritha Pizza");
//    Console.WriteLine("3. Tavuklu Pizza");
//}
//if (menuItem == "4")
//{
//    Console.WriteLine("-------İçecekler---------");
//    Console.WriteLine("1. Su");
//    Console.WriteLine("2. Ayran");
//    Console.WriteLine("3. Çay");
//}
//if (menuItem == "5")
//{
//    Console.WriteLine("-------Tatlılar---------");
//    Console.WriteLine("1. Trileçe");
//    Console.WriteLine("2. Kazandibi");
//    Console.WriteLine("3. Sütlaç");
//}
#endregion

#region Switch Case Yapısı

// Switch Case - Örnek 1 : Ay Seçme Örneği
//Console.WriteLine("Sayı giriniz.");
//int monthNumber = int.Parse(Console.ReadLine());
//switch (monthNumber)
//{
//	case 1: Console.WriteLine("Ocak"); break;
//    case 2: Console.WriteLine("Şubat"); break;
//    case 3: Console.WriteLine("Mart"); break;
//    case 4: Console.WriteLine("Nisan"); break;
//    case 5: Console.WriteLine("Mayıs"); break;
//    case 6: Console.WriteLine("Haziran"); break;
//    case 7: Console.WriteLine("Temmuz"); break;
//    case 8: Console.WriteLine("Ağustos"); break;
//    case 9: Console.WriteLine("Eylül"); break;
//    case 10: Console.WriteLine("Ekim"); break;
//    case 11: Console.WriteLine("Kasım"); break;
//    case 12: Console.WriteLine("Aralık"); break;
//    default:
//    Console.WriteLine("Hatalı veri girişi.");
//		break;
//}

// Switch Case - Örnek 2: Hesap Makinesi Örneği

int number1, number2, result;
char symbol;

Console.WriteLine("1.sayıyı giriniz: ");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("3.sayıyı giriniz: ");
number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen yapmak istediğiniz işlemin sembolünü giriniz.");
symbol = char.Parse(Console.ReadLine());

switch(symbol)
{
    case '+': result = number1 + number2;
        Console.WriteLine("Sonuç: "+result);
    break;

    case '-':
        result = number1 - number2;
        Console.WriteLine("Sonuç: "+result);
        break;

    case '*':
        result = number1 * number2;
        Console.WriteLine("Sonuç: "+result);
        break;

    case '/':
        result = number1 / number2;
        Console.WriteLine("Sonuç: "+result);
        break;
    default:
        Console.WriteLine("Hatalı sembol girişi");
        break;
}


#endregion

