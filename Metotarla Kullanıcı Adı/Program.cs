

using System.ComponentModel.Design;

Console.WriteLine("lÜTFEN ADINIZI GİRİNİZ:");
string kullaniciAdi=  Console.ReadLine();

Selamla(kullaniciAdi);  

static  string Selamla (string kAdi);
{
    if (string.IsNullOrEmpty(kullaniciAdi))
    {
        Console.WriteLine("Merhaba Dostum");

    }
   
   else
    {
        Console.WriteLine("Merhaba Dostum");

    }


    EkranaYaz("Bilge", "Adam", "Akademi");

    static void EkranaYaz(string gelenDeger, string gelenDeger1, string geleneDeger2);
    {
        Console.WriteLine("Ekrana sırasıyla değerleri yaz:{0},{1},{2}" gelenDeger, gelenDeger1, gelenDeger2);
    }

}
