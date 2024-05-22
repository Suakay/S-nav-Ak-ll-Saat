using Microsoft.Win32.SafeHandles;

Console.WriteLine("üRÜNÜN KDV'siz fiyatını giriniz:");
double sayi=Convert.ToDouble(Console.ReadLine());
double kdvdeger=Convert.ToDouble(Console.ReadLine());
double kdvlsayi= sayi* kdvdeger;
Console.WriteLine("kdv'Lİ fİYAT:" + kdvlsayi + "TL");
Console.ReadLine();