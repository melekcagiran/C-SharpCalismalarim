namespace deneme6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kelime girin:");
            string kelime=Console.ReadLine();
            bool sonuc= PalindromMu (kelime);
            if ( sonuc )
            {
                Console.WriteLine($"{kelime} bir palindromdur.");
            }
            else
            {
                Console.WriteLine($"{kelime} bir palindrom değildir.");
            }
            static bool PalindromMu  ( string kelime)
            {
                char[] chars = kelime.ToCharArray();
                Array.Reverse( chars );
                string terstenKelime=new string( chars );
                return kelime.Equals( terstenKelime,StringComparison.OrdinalIgnoreCase ) ;
            }
        }
    }
}
