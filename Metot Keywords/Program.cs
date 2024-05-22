

//Öğrenci sınıfı oluşturun.Property ve 2-3tane metoto yazdırın
//Telefon sınıfı oluşturun.Propery e 2-3 tane metot yazdırın

FiyatlariTopla(10.50, 20.45, 23.45, 32.46, 87.65);

static double  FiyatlariTopla(params double[] tutarlar)
{
    double toplamTutar = 0;
    foreach(double fiyat in tutarlar)
    {
        toplamTutar += fiyat;
    }
    return toplamTutar; 
}


