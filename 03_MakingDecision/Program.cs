
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

int number;
number = 26;
int result = number % 5;
Console.WriteLine(result);

#endregion
