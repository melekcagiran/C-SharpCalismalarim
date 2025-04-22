namespace metot_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obeb: " + ObebBul(sayi, sayi2));
            Console.WriteLine("Okek: " + OkekBul(sayi, sayi2));
        }

        static int ObebBul(int sayi, int sayi2)
        {
            int obeb = 1;
            for (int i = 1; i <= sayi && i <= sayi2; i++)
            {
                if (sayi % i == 0 && sayi2 % i == 0)
                {
                    obeb = i;
                }
            }
            return obeb;
        }
        static int OkekBul(int sayi, int sayi2)
        {
            return (sayi * sayi2) / ObebBul(sayi, sayi2);



        }
  

}   }   