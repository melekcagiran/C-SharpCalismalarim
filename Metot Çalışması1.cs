namespace metot_çalışması
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //soru: kulllanıcıdan bşr sayı al. pozitif mi negatif  mi kontrol ettir. void metodu ile 
          // çift mi tekmi kontrol ettiren bool metodu.


           Console.WriteLine("Kaç tane sayı gireceksiniz");
           int adet = int.Parse(Console.ReadLine());
           for (int i = 0; i < adet; i++)
                {
                 Console.WriteLine($"{i + 1}.sayıyı giriniz");
                 int sayi = (int.Parse(Console.ReadLine()));
                 PozitifNegatif(sayi);
                 if (CiftTek(sayi))
                 {
                   Console.WriteLine("Sayı çifttir.");
                 }
                 else
                 {
                   Console.WriteLine("Sayı tektir.");
                 }

           }
        }
        static void PozitifNegatif(int sayi)
        {
           if (sayi > 0)
           {
              Console.WriteLine("Pozitif");
           }
           else if (sayi < 0)
           {
             Console.WriteLine("Negatif");
           }
           else
           {
             Console.WriteLine("Sayı sıfırdır.");
           }
        }
        static bool CiftTek(int sayi)
        {
           if (sayi % 2 == 0)
           {
             return true; // çift
           }
           else
           {
             return false; // tek
           }
        }
        
    }
}
