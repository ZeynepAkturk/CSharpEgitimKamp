// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Void Metotlar

//()

//Geriye değer döndürmeyen metotlar
//customer --> listele, ekle, sil, güncelle
void CustomerList()
{
    Console.WriteLine("Ali Yıldız");
    Console.WriteLine("Ayşe Yıldız");
    Console.WriteLine("Merve Çınar");
    Console.WriteLine("Hakan Öztürk");
}
CustomerList();

void Sum()
{
    int x = 1;
    int y = 2;
    int z = x+y;
    Console.WriteLine(z);
}

Sum();

//geriye değer döndürmeyen

#endregion

#region Geriye Değer Döndürmeyen String Parametreli Metotlar

void WriteMethod(string customerName)
{
    Console.WriteLine(customerName);
}

WriteMethod("Zeynep Aktürk");

void CustomerCard(string name, string surName)
{
    Console.WriteLine("Müşteri : " + name + " " + surName);
}

CustomerCard("Zeynep", "Aktürk");
#endregion

#region Geriye Değer Döndürmeyen Int Parametreli Metotlar

void SumMethod(int number1, int number2, int number3 )
{
    int result = number1 + number2 + number3;
    Console.WriteLine(result);
}

SumMethod(1, 2, 3);
#endregion

#region Geriye Değer Döndüren Metotlar

string CustomerName()
{
    return "Zeynep Aktürk";
}

Console.WriteLine(CustomerName());

string StudentCard()
{
    string name = "Ali";
    string surName = "Kaya";
    return name + surName;
}
Console.WriteLine(StudentCard());
#endregion

#region Geriye Değer Döndüren Parametreli Metotlar
string CountryCard(string countryName, string capital, string flatColor )
{
    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi : " + flatColor;

    return cardInfo;
}
string x, y, z;
Console.WriteLine("Ülke adını giriniz: ");
x = Console.ReadLine();

Console.WriteLine("Başkent adını giriniz: ");
y = Console.ReadLine();

Console.WriteLine("Bayrak rengini giriniz: ");
z = Console.ReadLine();

Console.WriteLine(CountryCard(x, y, z));

#endregion

#region Geriye Değer Döndüren Int Parametreli Metotlar
int SumInt(int number1,int number2)
{
    return number1 + number2;
}

Console.WriteLine(SumInt(23, 34));
#endregion

#region Örnek Uygulama
string ExamResult(string student, int exam1, int exam2, int exam3) 
{
    int result = (exam1 + exam2 + exam3) / 3;
    if(result>=50)
    {
        return student  + " isimli öğrenci sınavı geçti."+ " Ortalama :" +result;
    }
    else
    {
        return student + " isimli öğrenci sınavı geçemedi." + " Ortalama :" + result;
    }
  
}

Console.WriteLine(ExamResult("Ali", 24, 56, 90));

#endregion