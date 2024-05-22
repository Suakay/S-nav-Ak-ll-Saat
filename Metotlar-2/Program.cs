

using System;


Console.WriteLine("1.sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("3.sayıyı giriniz:");
int sayi3 = Convert.ToInt32(Console.ReadLine());
ToplamaYap6(sayi1, sayi2, sayi3);
static int ToplamaYap6(int sayi1, int sayi2, int sayi3);
{
    return sayi1+sayi2+ sayi3;  
}