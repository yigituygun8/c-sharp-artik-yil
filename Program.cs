using System;

namespace osman
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2024;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            Console.WriteLine("Yıl: {0}\nAy: {1}\nGün: {2}", year, month, day);

            bool yearStatus = year % 4 == 0;

            if(yearStatus == true)
            {
                Console.WriteLine("{0} Artık Yıldır", year);
                Console.WriteLine("{0} Çift Sayıdır: {1}", year, yearStatus);

            }

            else
            {
                Console.WriteLine("{0} Artık Yıl Değil", year);
                if (year % 2 == 0)
                {
                    yearStatus = !yearStatus;
                    Console.WriteLine("{0} Yılı Çift Sayı: {1}", year, yearStatus);
                }
                else
                {
                    Console.WriteLine("{0} Yılı Tek Sayı: {1}", year, yearStatus);
                }

            }

            
            
        }
    }
}
