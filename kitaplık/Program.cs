namespace Kitaplık
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string secim;
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine ("**  Türkçe Kitaplar Kategorisi    **  Yabancı Kitaplar Kategorisi          **");
            Console.WriteLine();                                                                              
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri        **  7-Tuna Kılavuzu: Jules Verne         **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri          **  8-Bir Kuzey Macerası: Jack London    **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip **  9-Altıncı Koğuş: Anton Çehov         **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O. Atay  **  10-Kumarbaz: Doskoveski              **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: H.Yücel **  11-İki Şehrin Hikayesi:C.Dickens     **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf:S.Ali       **  12-Vişne Bahçesi: Anton.Çehov        **");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("*****İşlemler Menüsü *****");
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.WriteLine("Yapmak İtediğiniz İşlem Numarası: ");
            char islem;
            islem= Convert.ToChar(Console.ReadLine());
            if(islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen Fiyatını Öğrenmek istediğiniz kitabın numarasını giriniz");
                string numara;
                numara= Console.ReadLine();
                switch (numara)
                {
                    case "1":
                        Console.WriteLine("Çalıkuşu: 25 TL");
                        break;
                    case "2":
                        Console.WriteLine("Yaban: 20 TL");
                        break;
                    case "3":
                        Console.WriteLine("Sinekli Bakkal: 30 TL");
                        break;
                    case "4":
                        Console.WriteLine("Tehlikeli Oyunlar: 15 TL");
                        break;
                    case "5":
                        Console.WriteLine("Geçtiğim Günlerden: 18 TL");
                        break;
                    case "6":
                        Console.WriteLine("Kuyucaklı Yusuf: 22 TL");
                        break;
                    case "7":
                        Console.WriteLine("Tuna Kılavuzu: 28 TL");
                        break;
                    case "8":
                        Console.WriteLine("Bir Kuzey Macerası: 24 TL");
                        break;
                    case "9":
                        Console.WriteLine("Altıncı Koğuş: 19 TL");
                        break;
                    case "10":
                        Console.WriteLine("Kumarbaz: 21 TL");
                        break;
                    case "11":
                        Console.WriteLine("İki Şehrin Hikayesi: 27 TL");
                        break;
                    case "12":
                        Console.WriteLine("Vişne Bahçesi: 23 TL");
                        break;
                    default:
                        Console.WriteLine("Hatalı Kitap Numarası Girdiniz!");
                    break;
                }

            }
            else if(islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad,soyad,universite;
                Console.Write("Adınız: ");
                ad= Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad= Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite= Console.ReadLine();

                string dosya = @"C:\Users\Pc\OneDrive\Desktop\okur kayıt.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Ad: " + ad);
                sw.WriteLine("Soyad: " + soyad);
                sw.WriteLine("Üniversite: " + universite);
                sw.Close();
            }
            else if(islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine("***** Bugünün Kitabı Çalıkuşu  *****");
                Console.WriteLine
                  ("************************************");
            }
            else if(islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Pc\OneDrive\Desktop\kitap arşivi.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                //Kitap Arşivi
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            else if(islem == '5')
            {
                for (int i =1; i<=25; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası: ");
                    secim= Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamFiyat =  toplamFiyat +25;
                    }
                    else if (secim == "2")
                    {
                        toplamFiyat = toplamFiyat +20;
                    }
                    else if (secim == "3")
                    {
                        toplamFiyat = toplamFiyat +30;
                    }
                    else if (secim == "4")
                    {
                        toplamFiyat = toplamFiyat +15;
                    }
                    else if (secim == "5")
                    {
                        toplamFiyat = toplamFiyat +18;
                    }
                    else if (secim == "6")
                    {
                        toplamFiyat = toplamFiyat  +22;
                    }
                    else if (secim == "7")
                    {
                        toplamFiyat = toplamFiyat  +28;
                    }
                    else if (secim == "8")
                    {
                        toplamFiyat = toplamFiyat  +24;
                    }
                    else if (secim == "9")
                    {
                        toplamFiyat = toplamFiyat  +19;
                    }
                    else if (secim == "10")
                    {
                        toplamFiyat = toplamFiyat  +21;
                    }
                    else if (secim == "11")
                    {
                        toplamFiyat = toplamFiyat  +27;
                    }
                    else if (secim == "12")
                    {
                        toplamFiyat = toplamFiyat  +23;
                    }
                    else
                    
                        Console.WriteLine("Hatalı Kitap Numarası Girdiniz!");
                        Console.WriteLine();
                        Console.WriteLine("Başka Bir Kitap Almak İstermisiniz?");
                        string cevap= Console.ReadLine();
                        if (cevap=="h" || cevap=="hayır" || cevap=="HAYIR") break;

                }
                Console.WriteLine("Toplam Tutar: " + toplamFiyat);
            }
            else if(islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi =rnd.Next(1, 101);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi )
                    {
                        Console.Write("Daha Küçük Bir Sayı Giriniz");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük Bir Sayı Giriniz");
                    }
                    else if (tahmin == sayi) { 
                       
                        Console.WriteLine("Tebrikler Bildiniz!");
                        break;
                    }
                   
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Hatalı İşlem Numarası Girdiniz!");
            }


            Console.Read();
        }
    }
}
