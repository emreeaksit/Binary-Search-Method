using System;

namespace IkiliAramaOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] dizi = new int[11];
            Random random = new Random();
        
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(1, 50);
            }
            dizi[2] = 24;
            Console.WriteLine("Siralanmiş Dizi:");
            Console.WriteLine(string.Join(" ", dizi));
            Console.WriteLine();

            BubbleSort(dizi);

            Console.WriteLine("Sirali Dizi:");
            Console.WriteLine(string.Join(" ", dizi));
            Console.WriteLine();

            
            int aranandeger = 24;
            BinarySearch(dizi, aranandeger);
        }

       
        static void BubbleSort(int[] dizi)
        {
            int temp;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 0; j < dizi.Length - i - 1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                       
                        temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                    }
                }
            }
        }
        static void BinarySearch(int[] dizi, int aranandeger)
        {
            int ilk = 0;
            int son = dizi.Length - 1;
            int adim = 1;

            while (ilk <= son)
            {
                int orta = (ilk + son) / 2;
                int ortaDeger = dizi[orta];

                Console.WriteLine($" Adim {adim}: Baş={ilk}, Son={son}, Orta={orta}, OrtaDeğer={ortaDeger}");

                if (ortaDeger == aranandeger)
                {
                    Console.WriteLine($"\n {aranandeger} sayisi bulundu! İndis: {orta}");
                    return;
                }
                else if (ortaDeger > aranandeger)
                {
                    Console.WriteLine($" {ortaDeger} > {aranandeger}, sol tarafa geçiliyor.\n");
                    son = orta - 1;
                }
                else
                {
                    Console.WriteLine($" {ortaDeger} < {aranandeger}, sağ tarafa geçiliyor.\n");
                    ilk = orta + 1;
                }

                adim++;
            }

            Console.WriteLine($"\n {aranandeger} sayisi dizide bulunamadi.");
        }
    }
}
