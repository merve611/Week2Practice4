

using System.Diagnostics.Tracing;
using System.Threading.Channels;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Yol Arkadaşı : Tatil Uygulamasına Hoşgeldiniz !");

        string lokasyonBilgisi = "";                
        bool gecerliLokasyon = false;
        int lokasyonPrice = 0;
        int ulasımPrice = 0;
        int total = 0;
        bool anotherHoliday = true;
        string anotherHolidayAnswer = "";           //başka tatil cevabını tutan değişken

        while (anotherHoliday)                                      
        {
            while (!gecerliLokasyon)                    //geçerli lokasyon true ise bu döngüye girer
            {
                Console.WriteLine("Lütfen bir tatil lokasyonu seçiniz  \n Lokasyonlar: \n BODRUM Paket başlangıç fiyatı 4000 TL \n MARMARİS Paket başlangıç fiyatı 3000 TL \n ÇEŞME Paket başlangıç fiyatı 5000 TL ");
                string location = Console.ReadLine().ToUpper();         //lokasyonun tutulduğu değişken


                if (location == "ÇEŞME")
                {
                    lokasyonPrice += 5000;
                    lokasyonBilgisi = "Çeşme Tatilinde Yapılabilecekler\n Plaj ve Deniz Aktiviteleri \n Tarihi ve Kültürel Geziler \n Alaçatı Termal Sular ve Sağlık Turizmi \n Tekne Turları ";
                    gecerliLokasyon = true;                             //if te belirtilen lokasyon girilmiş ise geçerliLokasyonu true yapar ve else-ifleri sorgulamaz 

                }
                else if (location == "MARMARİS")
                {
                    lokasyonPrice += 3000;
                    lokasyonBilgisi = "Marmaris Tatilinde Yapılabilecekler\n Tarihi ve Kültürel Geziler \n Doğa ve Macera \n Su Sporları  \n Pazarlık ve Alışveriş ";
                    gecerliLokasyon = true;

                }
                else if (location == "BODRUM")
                {
                    lokasyonPrice += 4000;
                    lokasyonBilgisi = "Tekne Turları \n Lezzet Deneyimleri \n Gece Hayatı";
                    gecerliLokasyon = true;

                }

                if (!gecerliLokasyon)
                {
                    Console.WriteLine("Verilen 3 seçenek dışında bir lokasyon girdiniz");
                }
            }



            Console.WriteLine("Kaç kişilik bir tatil planlaması yapıyorsunuz ? ");
            int personNumber = int.Parse(Console.ReadLine());

            if (personNumber > 0)
            {
                Console.WriteLine(lokasyonBilgisi);
            }



            Console.WriteLine("Tatile ne şekilde gitmek istersiniz ?  \n 1. Kara Yolu \n 2.Hava Yolu \n Kara ise 1, Hava ise 2 girin");
            int ulasim = int.Parse(Console.ReadLine());

            if (ulasim == 1)
            {
                total = lokasyonPrice + 1500 * personNumber;
                Console.WriteLine("Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
            }
            else if (ulasim == 2)
            {
                total = lokasyonPrice + 4000 * personNumber;
                Console.WriteLine(" Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
            }
            else
            {
                Console.WriteLine("Verilen 2 seçenek dışında bir ulaşım yöntemi girdiniz");
            }


            Console.WriteLine(personNumber + " kişilik tatil planınız toplam : " + total + " TL");

            

            while (anotherHolidayAnswer != "evet" && anotherHolidayAnswer != "hayır")                           //başka tatile gitme cevabı hayır veya evet değilse yani her türlü bu while girecek
            {
                Console.WriteLine("Başka bir tatil planı yapmak istiyor musunuz ?");
                anotherHolidayAnswer = Console.ReadLine().ToLower();

                if (anotherHolidayAnswer == "evet")                                                 //evet ise  döngüyü baştan alır, hayır ise döngüye girmez 
                {
                    gecerliLokasyon = false;
                    anotherHoliday = true;
                }
                else if (anotherHolidayAnswer == "hayır")
                {
                    anotherHoliday = false;                                                         // en baştaki whilein içini false yapıp döngüye girmesini engeller
                }
                else
                {
                    Console.WriteLine("Evet yada Hayır girin");
                }
            }
        }



    }

}