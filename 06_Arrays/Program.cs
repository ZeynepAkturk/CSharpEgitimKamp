// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

#region Temel Dizi Tanımı ve Örnekleri

//dizi tanımlama : Değişken Türü [] DiziAdı = new DeğişkenTürü(ElemanSayısı)

 string[] colors = new string[4];
 colors[0] = "beyaz";
 colors[1] = "kırmızı";
 colors[2] = "mavi";
 colors[3] = "sarı";

 Console.WriteLine(colors[1]);

 string[] cities = new string[3];
 cities[0] = "Samsun";
 cities[1] = "Trabzon";

 Console.WriteLine(cities[2]);

//bir dizideki indeks değerine bir değer atanmazsa o indeksin default değeri 0 veya null olur.

 string[] cities_ = { "Prag", "Roma", "Atina", "Ankara" };
 Console.WriteLine(cities_[0]);


#endregion

#region Dizideki Tüm Elemanları Listeleme
 
 string[] colors_ = { "bordo", "mavi", "yeşil", "turkuaz" };
 for(int i =0; i<colors_.Length;i++)
 {
     Console.WriteLine(colors[i]);

 }

 int[] numbers = { 4, 85, 96, 74, 125, 522 };
 for (int i = 0; i < numbers.Length; i++)
 {
     if (numbers[i]%3==0)
     {
        Console.WriteLine(numbers[i]);
     }
 }

//Dizideki en büyük elemanı bulan bir program

 int[] myArray = { 47, 85, 95, 41, 25, 63, 789 };
 int maxNumber = myArray[0];
 for(int i=0; i<myArray.Length;i++)
 {
     if (myArray[i]>maxNumber)
     {
         maxNumber = myArray[i];
     }

 }
 Console.WriteLine(maxNumber);

#endregion

#region Dizi metotları

string[] persons = { "ali", "ayşe", "buse", "cem", "deniz" };
Console.WriteLine(persons.Length); //dizinin uzunluğunu verir.

int[] numbers_ = { 45, 85, 41, 1, 22, 35 };
Console.WriteLine(numbers.Max() + " " + numbers_.Min());

Array.Sort(numbers_); //küçükten büyüğe sıralar.
Array.Reverse(numbers_); //diziyi tersten sıralar.

for (int i = 0; i < numbers_.Length; i++)
{
    Console.WriteLine(numbers_[i]);
}

string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
int index = Array.IndexOf(customers, "merve"); //aranılan elemanın indeksini verir.
Console.WriteLine(index);


#endregion

#region Kullanıcıdan Değer Alma


string[] cities1 = new string[5];

for (int i = 0; i < cities1.Length; i++)
{
    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz : ");
    cities1[i] = Console.ReadLine();

}
Console.WriteLine("---------------------------");
for (int i = 0; i < cities1.Length; i++)
{
    Console.WriteLine(cities1[i]);
}



#endregion