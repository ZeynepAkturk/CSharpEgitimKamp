// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Alt alta 10 Tane Yıldız Oluşturma

//for(int i=1;i<=10;i++)
//{
//    Console.WriteLine("*");
//}
#endregion

#region Alt alta ve her satırda 10 tane yıldız oluşturma

//for(int i=1;i<=10;i++)
//{
//    Console.WriteLine("**********");
//}
#endregion

#region Yıldızlarla Dik Üçgen Oluşturma

//for(int i=1; i<=5; i++)
//{
//    for(int j=1; j<=i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion

#region Yıldızlarla Ters Dik Üçgen Oluşturma

//for (int i=5; i>=1; i--)
//{
//    for (int j =1; j <=i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion

#region Dik Üçgen ve Ters Dİk Üçgen Birleşimi

//for(int i=1;i<=5;i++)
//{
//    for(int j=1; j<=i;j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//for(int i=5; i>=1; i--)
//{
//    for(int j=1; j<=i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion

#region Yıldızlarla Elmas Görünümü
//int n = 5;
//for(int i=1;i<=n; i++)
//{
//    for(int j=n-1;j>=0;j--)
//    {
//        Console.Write(" ");
//    }
//    for(int k=1;k<=2*i-1;k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//for(int i=n-1;i>=1;i--)
//{
//    for(int j=n;j>0; j--)
//    {
//        Console.Write(" ");
//    }
//    for(int k=2*i-1; k>0; k--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion

#region Piramit 
int n = 5;
for(int i=1; i<=n;i++)
{
    //boşluklar için
    for(int j=n-i;j>0;j--)
    {
        Console.Write(" ");
    }
    //yıldızlar için
    for(int k=1;k<=2*i-1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
#endregion

#region Ters Piramit
int m = 5;
for(int i=m;i>=1;i--)
{
    for(int j=m-i;j>0; j--)
    {
        Console.Write(" ");
    }
    for(int k=1; k<=2*i-1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

#endregion