
int gelenSayi;
Console.WriteLine("Lütfen karesini ve küpünü almak istediğiniz sayıyı girini:");
string gelenSayiString  = Console.ReadLine();    

gelenSayi=int.Parse(gelenSayiString);
Console.WriteLine("Sayının Karesi:" + gelenSayi * gelenSayi);
Console.WriteLine("Sayının küpü:"+gelenSayi*gelenSayi*gelenSayi);