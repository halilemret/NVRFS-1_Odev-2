using System;
using System.Collections.Generic;


public class RakamToplami
{
    public static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        string sayi = Console.ReadLine();

        int toplam = 0;
        foreach (char rakamChar in sayi)
        {
            if (char.IsDigit(rakamChar))
            {
                int rakam = int.Parse(rakamChar.ToString());
                toplam += rakam;
            }
        }
    }
}

//        Console.WriteLine("Rakamların toplamı: " + toplam);
//    }
//}
//public class SayiAlma
//{
//    public static void Main(string[] args)
//    {
//        int sayi;
//        bool gecerliSayi = false;

//        while (!gecerliSayi)
//        {
//            Console.Write("10 ile 100 arasında bir sayı girin: ");
//            string giris = Console.ReadLine();

//            if (int.TryParse(giris, out sayi))
//            {
//                if (sayi >= 10 && sayi <= 100)
//                {
//                    gecerliSayi = true;
//                    Console.WriteLine("Girdiğiniz sayı geçerli: " + sayi);
//                }
//                else
//                {
//                    Console.WriteLine("Girdiğiniz sayı 10 ile 100 arasında olmalıdır.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
//            }
//        }
//    }
//}

//public class YasKategorisi
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Yaşınızı girin: ");
//        string yasStr = Console.ReadLine();

//        if (int.TryParse(yasStr, out int yas))
//        {
//            List<int> yaslar = new List<int>() { yas }; // Yaşı bir listeye ekle

//            foreach (int tekYas in yaslar) 
//            {
//                string kategori = "";

//                if (tekYas >= 0 && tekYas <= 12)
//                {
//                    kategori = "Çocuk";
//                }
//                else if (tekYas >= 13 && tekYas <= 19)
//                {
//                    kategori = "Genç";
//                }
//                else if (tekYas >= 20 && tekYas <= 64)
//                {
//                    kategori = "Yetişkin";
//                }
//                else
//                {
//                    kategori = "Yaşlı";
//                }

//                Console.WriteLine("Yaş: " + tekYas + ", Kategori: " + kategori);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
//        }
//    }
//}

//public class TekrarEdenElemanlar
//{
//    public static void Main(string[] args)
//    {
//        int[] dizi = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };

//        Dictionary<int, int> elemanSayilari = new Dictionary<int, int>();
//        List<int> tekrarEdenler = new List<int>();

//        foreach (int eleman in dizi)
//        {
//            if (elemanSayilari.ContainsKey(eleman))
//            {
//                elemanSayilari[eleman]++;
//                if (elemanSayilari[eleman] == 2) // İlk tekrarı bulduğumuzda listeye ekle
//                {
//                    tekrarEdenler.Add(eleman);
//                }
//            }
//            else
//            {
//                elemanSayilari[eleman] = 1;
//            }
//        }

//        Console.WriteLine("Tekrar eden elemanlar:");
//        foreach (int tekrarEden in tekrarEdenler)
//        {
//            Console.WriteLine(tekrarEden);
//        }
//    }
//}

//public class EnUzunEnKisaKelime
//{
//    public static void Main(string[] args)
//    {
//        string[] dizi = { "elma", "armut", "çilek", "muz", "karpuz" };

//        string enUzun = dizi[0];
//        string enKisa = dizi[0];

//        foreach (string kelime in dizi)
//        {
//            if (kelime.Length > enUzun.Length)
//            {
//                enUzun = kelime;
//            }

//            if (kelime.Length < enKisa.Length)
//            {
//                enKisa = kelime;
//            }
//        }

//        Console.WriteLine("En uzun kelime: " + enUzun);
//        Console.WriteLine("En kısa kelime: " + enKisa);
//    }
//}

//public class CümleyiSirala
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Bir cümle girin: ");
//        string cumle = Console.ReadLine();

//        string[] kelimeler = cumle.Split(' '); // Cümleyi kelimelere ayır

//        Array.Sort(kelimeler); // Kelimeleri alfabetik olarak sırala

//        Console.WriteLine("Sıralanmış kelimeler:");
//        foreach (string kelime in kelimeler)
//        {
//            Console.WriteLine(kelime);
//        }
//    }
//}

//public class DiziyiGenislet
//{
//    public static void Main(string[] args)
//    {
//        List<string> dizi = new List<string>() { "elma", "armut" };

//        Console.WriteLine("Dizi boyutu: " + dizi.Count);

//        dizi.Add("çilek"); // Diziye yeni bir eleman ekle

//        Console.WriteLine("Dizi boyutu: " + dizi.Count);

//        foreach (string kelime in dizi)
//        {
//            Console.WriteLine(kelime);
//        }
//    }
//}
//public class KelimeleriTerstenYazdir
//{
//    public static void Main(string[] args)
//    {
//        List<string> kelimeler = new List<string>();

//        while (true)
//        {
//            Console.Write("Bir kelime girin (çıkmak için 'q'): ");
//            string kelime = Console.ReadLine();

//            if (kelime == "q")
//            {
//                break;
//            }

//            kelimeler.Add(kelime);
//        }

//        Console.WriteLine("Tersten sırayla yazılan kelimeler:");
//        for (int i = kelimeler.Count - 1; i >= 0; i--)
//        {
//            Console.WriteLine(kelimeler[i]);
//        }
//    }
//public class SayilariSiralaOrtalama
//{
//    public static void Main(string[] args)
//    {
//        List<double> sayilar = new List<double>();

//        while (true)
//        {
//            Console.Write("Bir sayı girin (çıkmak için 'q'): ");
//            string giris = Console.ReadLine();

//            if (giris == "q")
//            {
//                break;
//            }

//            if (double.TryParse(giris, out double sayi))
//            {
//                sayilar.Add(sayi);
//            }
//            else
//            {
//                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
//            }
//        }

//        if (sayilar.Count > 0)
//        {
//            double ortalama = sayilar.Average(); // Sayıların ortalamasını al
//            sayilar.Sort(); // Sayıları küçükten büyüğe sırala

//            Console.WriteLine("Sayıların ortalaması: " + ortalama);
//            Console.WriteLine("Sıralanmış sayılar:");
//            foreach (double sayi in sayilar)
//            {
//                Console.WriteLine(sayi);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Hiç sayı girilmedi.");
//        }
//    }
//}

//public class OndanKucukleriSil
//{
//    public static void Main(string[] args)
//    {
//        List<int> sayilar = new List<int>() { 5, 15, 2, 20, 8, 12 };

//        sayilar.RemoveAll(sayi => sayi < 10); // 10'dan küçük sayıları sil

//        Console.WriteLine("10'dan küçük sayılar silindikten sonra:");
//        foreach (int sayi in sayilar)
//        {
//            Console.WriteLine(sayi);
//        }
//    }
//}

//public class NotlariGuncelle
//{
//    public static void Main(string[] args)
//    {
//        List<int> notlar = new List<int>() { 40, 60, 30, 70, 50, 20 };

//        for (int i = 0; i < notlar.Count; i++)
//        {
//            if (notlar[i] < 50)
//            {
//                notlar[i] = 50; // 50'den küçük notları 50 olarak güncelle
//            }
//        }

//        Console.WriteLine("Güncellenmiş notlar:");
//        foreach (int not in notlar)
//        {
//            Console.WriteLine(not);
//        }
//    }
//}