using OOP_ÜTÜ;

UTU ütü = new UTU();//ütü sınıfından bir nesne oluşturuyourz
ütü.KazanlıMı = true;
ütü.Marka = "BOSCH";
ütü.Renk = "BEYAZ";

Console.WriteLine("ütü nesnesi aşağıdaki bilgilerle oluşturuldu:");

Console.WriteLine(new string('*', 30));

UTU ütü2 = new UTU ("arçelik", "kazanlı", "BEYAZ");
Console.WriteLine(new string('*', 30));

UTU ütü3 = new UTU("BOSCH");
ütü3.KazanlıMı=true;
ütü3.Renk = "KIRMIZI";
ütü3.sıcaklı = 0;


Console.WriteLine(new string('*', 30));

UTU ütü4 = new UTU("BEKO");
ütü4.Renk = "SİYAH";
ütü4.sıcaklı = 0;
ütü4.KazanlıMı = true;

Console.WriteLine(new string('*', 30));
UTU ütü5 = new UTU("ROWENTA", null, default, default);
ütü5.Isin(150);