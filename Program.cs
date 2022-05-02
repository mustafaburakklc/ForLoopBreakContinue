using System;

namespace ForLoopBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
           /*System.Console.WriteLine("Lütfen bir sayi giriniz: ");
           int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
               if(i%2==1)
                System.Console.Write(i+"  "); 
            }*/
            
            
            
            //1 ile 1000 arasindaki tek cift sayilarin kendi iclerinde toplamlarini ekrana yazdir.
            
            
            
            /*int tekToplam=0;
            int ciftToplam=0;

            for (int i = 1; i <=1000; i++)
            {
                if(i%2==1)
                    tekToplam+=i;
                else
                    ciftToplam+=i;
            }
            System.Console.WriteLine("1 den 1000 e kadar olan sayilardan ciftlerin toplami: "+ciftToplam);
            System.Console.WriteLine("1 den 1000 e kadar olan sayilardan teklerin toplami: "+tekToplam);
            */
            System.Console.Write("Baslangic sayisini giriniz: ");
            int start=int.Parse(Console.ReadLine());
            System.Console.Write("Isleme dahil etmek istediginiz son sayiyi giriniz: ");
            int finish=int.Parse(Console.ReadLine());

            System.Console.WriteLine(ciftTopla(start,finish));

            
            


        }

        private static int ciftTopla(int start,int finish)
         {
             int sonuc=0;
             for (int i = start; i <= finish; i++)
             {
                 if (i%2==1)
                    continue;
                else
                    sonuc+=i;
                 
             }

             return sonuc;
         }
    }
}
