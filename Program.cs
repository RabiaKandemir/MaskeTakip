
using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;
using System;

/*Vatandas vatandas1 = new Vatandas();*/
//SelamVer("Rabia");
//SelamVer();

//int sonuc = Topla(6, 58);

//Diziler / Arrays

//string ogrenci1 = "Engin";
//string ogrenci2 = "Kerem";
//string ogrenci3 = "Berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

//string[] ogrenciler = new string[3];
//ogrenciler[0] = "Engin";
//ogrenciler[1] = "Kerem";
//ogrenciler[2] = "Berkay";
//ogrenciler = new string[4]; 
//ogrenciler[4] = "İlker";

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    Console.WriteLine(ogrenciler[i]);
//}

//string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
//string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
//Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "RABİA";
person1.LastName = "DEMİROĞ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

//Person person2 = new Person();
//person2.FirstName = "Murat";

//foreach (var sehir in sehirler1)
//{
//    Console.WriteLine(sehir);
//}

//List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
//yeniSehirler1.Add("Adana1");
//foreach (var sehir in yeniSehirler1)
//{
//    Console.WriteLine(sehir);
//}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Rabia";
    string soyad = "Kandemir";
    int dogumYili = 1985;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}