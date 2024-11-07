//using System;
//using System.Collections.Generic;

//public class Tekstil
//{
//    public string Ad { get; set; }
//    public double Fiyat { get; set; }
//    public string KumasTuru { get; set; }
//    public string Beden { get; set; }
//    public string UreticiFirma { get; set; }

//    // Constructor
//    public Tekstil(string ad, double fiyat, string kumasTuru, string beden, string ureticiFirma)
//    {
//        Ad = ad;
//        Fiyat = fiyat;
//        KumasTuru = kumasTuru;
//        Beden = beden;
//        UreticiFirma = ureticiFirma;
//    }

//    // KDV uygulaması Tekstil için %20
//    public double KdvFiyat()
//    {
//        return Fiyat * 1.20; // %20 KDV
//    }
//}

//public class CepTelefonu
//{
//    public string Ad { get; set; }
//    public double Fiyat { get; set; }
//    public string Ozellikler { get; set; }
//    public string Marka { get; set; }

//    // Constructor
//    public CepTelefonu(string ad, double fiyat, string ozellikler, string marka)
//    {
//        Ad = ad;
//        Fiyat = fiyat;
//        Ozellikler = ozellikler;
//        Marka = marka;
//    }

//    // KDV uygulaması CepTelefonu için %120
//    public double KdvFiyat()
//    {
//        return Fiyat * 2.20; // %120 KDV
//    }
//}

//public class Ekmek
//{
//    public string Ad { get; set; }
//    public double Fiyat { get; set; }
//    public string EkmekTuru { get; set; }
//    public double Gramaj { get; set; }

//    // Constructor
//    public Ekmek(string ad, double fiyat, string ekmekTuru, double gramaj)
//    {
//        Ad = ad;
//        Fiyat = fiyat;
//        EkmekTuru = ekmekTuru;
//        Gramaj = gramaj;
//    }

//    // KDV uygulaması Ekmek için %20
//    public double KdvFiyat()
//    {
//        return Fiyat * 1.20; // %20 KDV
//    }
//}

//public class Sepet
//{
//    public List<object> Urunler { get; set; } = new List<object>();

//    // Sepete ürün ekle
//    public void UrunEkle(object urun)
//    {
//        Urunler.Add(urun);
//    }

//    // Toplam tutarı hesapla
//    public double ToplamTutar()
//    {
//        double toplam = 0;
//        foreach (var urun in Urunler)
//        {
//            // Ürün türüne göre KDV'li fiyatı ekle
//            if (urun is Tekstil)
//                toplam += ((Tekstil)urun).KdvFiyat();
//            else if (urun is CepTelefonu)
//                toplam += ((CepTelefonu)urun).KdvFiyat();
//            else if (urun is Ekmek)
//                toplam += ((Ekmek)urun).KdvFiyat();
//        }
//        return toplam;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Tekstil ürününü oluştur
//        Tekstil tekstil = new Tekstil("Pantolon", 200, "Kot", "M", "Firma A");

//        // Cep Telefonu ürününü oluştur
//        CepTelefonu cepTelefonu = new CepTelefonu("iPhone", 8000, "64GB, Siyah", "Apple");

//        // Ekmek ürününü oluştur
//        Ekmek ekmek = new Ekmek("Beyaz Ekmek", 5, "Beyaz", 300);

//        // Sepet nesnesini oluştur
//        Sepet sepet = new Sepet();

//        // Ürünleri sepete ekle
//        sepet.UrunEkle(tekstil);
//        sepet.UrunEkle(cepTelefonu);
//        sepet.UrunEkle(ekmek);

//        // Toplam tutarı yazdır
//        Console.WriteLine($"Toplam Tutar: {sepet.ToplamTutar()} TL");
//    }
//}
using System;
using System.Collections.Generic;

public class Tekstil
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }
    public string KumasTuru { get; set; }
    public string Beden { get; set; }
    public string UreticiFirma { get; set; }

    // Constructor
    public Tekstil(string ad, double fiyat, string kumasTuru, string beden, string ureticiFirma)
    {
        Ad = ad;
        Fiyat = fiyat;
        KumasTuru = kumasTuru;
        Beden = beden;
        UreticiFirma = ureticiFirma;
    }

    // KDV uygulaması Tekstil için %20
    public double KdvFiyat()
    {
        return Fiyat * 1.20; // %20 KDV
    }
}

public class CepTelefonu
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }
    public string Ozellikler { get; set; }
    public string Marka { get; set; }

    // Constructor
    public CepTelefonu(string ad, double fiyat, string ozellikler, string marka)
    {
        Ad = ad;
        Fiyat = fiyat;
        Ozellikler = ozellikler;
        Marka = marka;
    }

    // KDV uygulaması CepTelefonu için %120
    public double KdvFiyat()
    {
        return Fiyat * 2.20; // %120 KDV
    }
}

public class Ekmek
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }
    public string EkmekTuru { get; set; }
    public double Gramaj { get; set; }

    // Constructor
    public Ekmek(string ad, double fiyat, string ekmekTuru, double gramaj)
    {
        Ad = ad;
        Fiyat = fiyat;
        EkmekTuru = ekmekTuru;
        Gramaj = gramaj;
    }

    // KDV uygulaması Ekmek için %20
    public double KdvFiyat()
    {
        return Fiyat * 1.20; // %20 KDV
    }
}

public class Sepet
{
    public List<object> Urunler { get; set; } = new List<object>();

    // Sepete ürün ekle
    public void UrunEkle(object urun)
    {
        Urunler.Add(urun);
    }

    // Toplam tutarı hesapla
    public double ToplamTutar()
    {
        double toplam = 0;
        foreach (var urun in Urunler)
        {
            // Ürün türüne göre KDV'li fiyatı ekle
            if (urun is Tekstil)
                toplam += ((Tekstil)urun).KdvFiyat();
            else if (urun is CepTelefonu)
                toplam += ((CepTelefonu)urun).KdvFiyat();
            else if (urun is Ekmek)
                toplam += ((Ekmek)urun).KdvFiyat();
        }
        return toplam;
    }
}

class Program
{
    static void Main()
    {
        // Kullanıcıdan Tekstil ürünü bilgilerini al
        Console.WriteLine("Tekstil Ürünü Bilgilerini Girin:");
        Console.Write("Ürün Adı: ");
        string tekstilAd = Console.ReadLine();
        Console.Write("Fiyat: ");
        double tekstilFiyat = double.Parse(Console.ReadLine());
        Console.Write("Kumaş Türü: ");
        string tekstilKumasTuru = Console.ReadLine();
        Console.Write("Beden: ");
        string tekstilBeden = Console.ReadLine();
        Console.Write("Üretici Firma: ");
        string tekstilUreticiFirma = Console.ReadLine();

        Tekstil tekstil = new Tekstil(tekstilAd, tekstilFiyat, tekstilKumasTuru, tekstilBeden, tekstilUreticiFirma);

        // Kullanıcıdan Cep Telefonu ürünü bilgilerini al
        Console.WriteLine("\nCep Telefonu Ürünü Bilgilerini Girin:");
        Console.Write("Ürün Adı: ");
        string cepTelefonuAd = Console.ReadLine();
        Console.Write("Fiyat: ");
        double cepTelefonuFiyat = double.Parse(Console.ReadLine());
        Console.Write("Özellikler: ");
        string cepTelefonuOzellikler = Console.ReadLine();
        Console.Write("Marka: ");
        string cepTelefonuMarka = Console.ReadLine();

        CepTelefonu cepTelefonu = new CepTelefonu(cepTelefonuAd, cepTelefonuFiyat, cepTelefonuOzellikler, cepTelefonuMarka);

        // Kullanıcıdan Ekmek ürünü bilgilerini al
        Console.WriteLine("\nEkmek Ürünü Bilgilerini Girin:");
        Console.Write("Ürün Adı: ");
        string ekmekAd = Console.ReadLine();
        Console.Write("Fiyat: ");
        double ekmekFiyat = double.Parse(Console.ReadLine());
        Console.Write("Ekmek Türü: ");
        string ekmekTuru = Console.ReadLine();
        Console.Write("Gramaj: ");
        double ekmekGramaj = double.Parse(Console.ReadLine());

        Ekmek ekmek = new Ekmek(ekmekAd, ekmekFiyat, ekmekTuru, ekmekGramaj);

        // Sepet nesnesini oluştur
        Sepet sepet = new Sepet();

        // Ürünleri sepete ekle
        sepet.UrunEkle(tekstil);
        sepet.UrunEkle(cepTelefonu);
        sepet.UrunEkle(ekmek);

        // Toplam tutarı yazdır
        Console.WriteLine($"\nToplam Tutar: {sepet.ToplamTutar()} TL");
    }
}

