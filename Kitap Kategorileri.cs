namespace KitapKategorileri;
enum KitapKategori
    {
        BilimKurgu = 0,
        DunyaKlasikleri = 1,
        Psikoloji = 2
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Lütfen bir kategori giriniz (BilimKurgu, DunyaKlasikleri, Psikoloji): ");
            string kategoriStr = Console.ReadLine();

            if (Enum.TryParse(kategoriStr, out KitapKategori kategori))
            {
                switch (kategori)
                {
                    case KitapKategori.BilimKurgu:
                        Console.WriteLine("Bilim Kurgu kategorisindeki kitaplar A reyonundadır.");
                        break;
                    case KitapKategori.DunyaKlasikleri:
                        Console.WriteLine("Dünya Klasikleri kategorisindeki kitaplar B reyonundadır.");
                        break;
                    case KitapKategori.Psikoloji:
                        Console.WriteLine("Psikoloji kategorisindeki kitaplar C reyonundadır.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz kategori girdiniz.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz kategori girdiniz. Lütfen doğru yazım ile tekrar deneyiniz.");
            }
        }
    }



