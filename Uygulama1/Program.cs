namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu belirtiniz:");
            int diziBoyutu = int.Parse(Console.ReadLine());
            int[] sayilar = new int[diziBoyutu];

            for (int i = 0; i < diziBoyutu; i++)
            {
                Console.Write("Dizinin {0}. Elemanını giriniz:",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in sayilar)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
