namespace Seyahat_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
            /*
             
             PROJE EN KOLAY YOLLU BİR PROJEDİR

            1 - Olarak - Ana Menüden Yönetici Ve Müşteri Paneli Seçilmektedir

            2 - Olarak - Müşteri Panelinde Her Şey Görünümlü Ve Rahat Kullanışlı , Sefer,Saatler,Fiyatlar, Teknoloji Olarak Direkt Satın Alıp Koltuk Numarasına Kadar Bilgi Verilir

            3 - Olarak - Yönetici Panelinde Sadece Günlük Satış Ve Kaç Koltuk Satıldığını Gösterir 
            
            4 - Olarak  - Yönetici Paneli Şifrelidir Ve Herkes Yönetici Paneline Giremez Yanlış Şifre Girilmesi Dahilde  Program Kilitlenir
            
            

            *********************************************************************************************************
            
            == Çok Kolay Bir Projedir Ve Hata Almadan Sorunsuz Bütün İşlemlerini Yapabilirler



             */





            int gunlukSatis = 0;
            int koltuk = 0;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Ana Menü ===");
                Console.WriteLine("1. Müşteri Paneli");
                Console.WriteLine("2. Yönetici Paneli");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {

                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("1. Sefer Ara");
                        Console.WriteLine("2. Fiyatlara Bak");
                        Console.WriteLine("0. Ana Menüye Dön");
                        Console.Write("Seçiminiz: ");
                        int ifadeler = Convert.ToInt32(Console.ReadLine());

                        if (ifadeler == 1)
                        {

                            Console.WriteLine("Gitmek istediğiniz şehri girin:");
                            string sehir = Console.ReadLine().ToUpper();

                            Console.WriteLine("Sefer bulundu! Saatler: 1 tane mevcut.");
                            Console.WriteLine("1. Satın Al");
                            Console.WriteLine("2. İptal Et");
                            Console.Write("Seçiminiz: ");
                            int almakalmamak = Convert.ToInt32(Console.ReadLine());

                            if (almakalmamak == 1)
                            {
                                Random s = new Random();
                                int koltukNumarasi = s.Next(10, 100); // Koltuk numarası

                                Console.Write("1. Kişinin Bilet Fiyatını Girin: ");
                                int fiyat1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("2. Kişinin Bilet Fiyatını Girin: ");
                                int fiyat2 = Convert.ToInt32(Console.ReadLine());

                                gunlukSatis += fiyat1 + fiyat2;
                                koltuk++; // Koltuk sayısını arttır

                                Console.WriteLine($"Biletiniz Satın Alınmıştır Koltuk Numarası: {koltukNumarasi}");
                                Console.WriteLine("Devam etmek için Enter'a basın.");
                                Console.ReadLine();
                            }
                            else if (almakalmamak == 2)
                            {
                                Console.WriteLine("İşleminiz iptal edilmiştir.");
                                break; // Müşteri paneline dön
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim.");
                                break;
                            }
                        }
                        else if (ifadeler == 2)
                        {

                            Console.WriteLine("Fiyatlar:");
                            Console.WriteLine("Yetişkin: 150 TL");
                            Console.WriteLine("Çocuk: 50 TL");
                            Console.WriteLine("Öğrenci: 20 TL");
                            Console.WriteLine("Emekli: 5 TL");

                            Console.WriteLine("Devam etmek için Enter'a basın.");
                            Console.ReadLine();
                        }
                        else if (ifadeler == 0)
                        {
                            break; // Ana menüye dön
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim.");
                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (secim == 2)
                {

                    string sifre = "eymen";
                    int hak = 3;

                    while (hak > 0)
                    {
                        Console.Write("Yönetici şifresini girin: ");
                        string girilenSifre = Console.ReadLine();
                        hak--;

                        if (girilenSifre == sifre)
                        {
                            Console.WriteLine("Şifre doğru. Yönetici paneline erişim sağlandı.");
                            break;
                        }
                        else if (hak == 0)
                        {
                            Console.WriteLine("Şifre hatalı! Sistem kilitlendi.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Yanlış şifre. Kalan hak: " + hak);
                        }
                    }

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Yönetici Paneli ===");
                        Console.WriteLine("1. Günlük Satışları Gör");
                        Console.WriteLine("2. Satılan Koltuk Sayısını Gör");
                        Console.WriteLine("0. Ana Menüye Dön");
                        Console.Write("Seçiminiz: ");
                        int yoneticiSecim = Convert.ToInt32(Console.ReadLine());

                        if (yoneticiSecim == 1)
                        {
                            Console.WriteLine($"Bugün yapılan toplam satış: {gunlukSatis} TL");
                            Console.WriteLine("Devam etmek için Enter'a basın.");
                            Console.ReadLine();
                        }
                        else if (yoneticiSecim == 2)
                        {
                            Console.WriteLine($"Satılan toplam koltuk sayısı: {koltuk}");
                            Console.WriteLine("Devam etmek için Enter'a basın.");
                            Console.ReadLine();
                        }
                        else if (yoneticiSecim == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (secim == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
