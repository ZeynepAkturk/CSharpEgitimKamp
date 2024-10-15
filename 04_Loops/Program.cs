// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region For Döngüsü

//Döngüler
// For(x;y;z)
//x: başlangıç, y:bitiş, z:artış-azalış

int i;
for (i = 1; i <= 5; i++)
{
    Console.WriteLine("CSharp Kampı");
}

for (int j = 0; j <= 20; j += 3)
{
    Console.WriteLine(j);
}
#endregion

#region For Döngüsünün Karar Yapılarıyla Kullanılması

//Örnek 1: 0 dan 100'e kadar 5'e tam bölünen sayılar

for ( i = 0; i <= 100; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

//Örnek 2: 1 den 10'a kadar olan sayıların toplamı

int totalValue = 0;
for (int j = 0; j <= 10; j++)
{
    totalValue += j;
}
Console.WriteLine(totalValue);

#endregion

#region While Döngüsü
//While döngüsü, şart sağlandığı müddetçe devam eder.

int m = 0;
while (m <= 10)
{
    m++;
    Console.WriteLine(m);
}

//Örnek 1: Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
//456
Console.WriteLine("Sayıyı giriniz.");
int number = int.Parse(Console.ReadLine());
int ones, tens, hundreds;
int sum;
hundreds = number / 100;
ones = number % 10;
tens = (number % 100) / 10;

Console.WriteLine(hundreds);
Console.WriteLine(tens);
Console.WriteLine(ones);

sum = hundreds + tens + ones;
Console.WriteLine(sum);


#endregion


