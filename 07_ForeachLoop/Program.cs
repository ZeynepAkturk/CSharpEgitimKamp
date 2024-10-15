// See https://aka.ms/new-console-template for more information

#region ForEach Döngüsü

//ForEach (1;2;3;4)
//1.parametre: değişken türü
//2.parametre: değişken ismi
//3.parametre: in kavramı
//4.parametre: liste,koleksiyon,dizi

//dizi elemanları foreach döngüsünde gösterme

string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

foreach(string city in cities)
{ 
    Console.WriteLine(city);
}


//foreach döngüsüyle dizideki çift elemanları bulma

int[] numbers = { 45, 78, 985, 635, 11, 34 };
foreach(int number in numbers)
{
    if (number % 2 == 0)
        Console.WriteLine(number);
}

//List ve foreach yapısı

List<int> numbers2 = new List<int>()
{
    1,2,3,4
};
foreach(int number in numbers2)
{
    Console.WriteLine(number);
}

// Foreach ile bir kelimeyi harflerine ayırma

string word = "Merhaba";
foreach(char character in word)
{ Console.WriteLine(character); 
}

#endregion

#region Örnek Sınav Sistemi Uygulaması
Console.WriteLine("*** C# Eğitim Kampı Sınav Uygulaması ***");
Console.WriteLine();
//Öğrenci sayısını alma
Console.WriteLine("------------------------------------------");
Console.WriteLine("Sınıfınızda kaç öğrenci var?");
int studentCount = int.Parse(Console.ReadLine());

//Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
Console.WriteLine("------------------------------------------");
string[] studentNames = new string[studentCount];
double[] studentExaming = new double[studentCount];
for (int i = 0; i < studentCount; i++)
{
    Console.Write($"{i + 1}. öğrencinin ismini giriniz:");
    studentNames[i] = Console.ReadLine();

    double totalExamResult = 0;

    //her öğrenci için 3 sınav notu girişi
    for(int j=0; j<3; j++)
    {
        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:");
        double value = double.Parse(Console.ReadLine());
        totalExamResult += value;
    }

    studentExaming[i] = totalExamResult / 3;

}

//Öğrencilerin ortalamaları

for(int i=0; i<studentCount;i++)
{
    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExaming[i]}");
    if (studentExaming[i]>=50)
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
    }
    else
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
    }
    Console.WriteLine();
    Console.WriteLine("------------------------------------------");
}

#endregion


