using Week4Final;

public class Program
{
    public static void Main()
    {
        bool makineSecimi = true;

        while (makineSecimi)
        {
            Console.WriteLine("Lütfen seçiminizi yapın:\n1-Telefon\n2-Bilgisayar");
            if (int.TryParse(Console.ReadLine(), out int secim))
            {
                

                switch (secim)
                {
                    case 1:
                        Telefon tel = new Telefon();
                        Console.WriteLine("Telefonunuz için bilgileri giriniz:");

                        Console.Write("Seri Numarası: ");
                        tel.SeriNumarasi = Console.ReadLine();

                        Console.Write("Ad: ");
                        tel.Ad = Console.ReadLine();

                        Console.Write("Açıklama: ");
                        tel.Aciklama = Console.ReadLine();

                        Console.Write("İşletim Sistemi: ");
                        tel.IsletimSistemi = Console.ReadLine();

                        Console.Write("TR Lisanslı mı? (true/false): ");
                        tel.TrLisansVarMi =Convert.ToBoolean(Console.ReadLine());

                        tel.UrunAdiGetir();
                        tel.BilgileriYazdır();

                        break;

                    case 2:
                        Bilgisayar pc = new Bilgisayar();
                        Console.WriteLine("Bilgisayarınız için bilgileri giriniz:");

                        Console.Write("Seri Numarası: ");
                        pc.SeriNumarasi = Console.ReadLine();

                        Console.Write("Ad: ");
                        pc.Ad = Console.ReadLine();

                        Console.Write("Açıklama: ");
                        pc.Aciklama = Console.ReadLine();

                        Console.Write("İşletim Sistemi: ");
                        pc.IsletimSistemi = Console.ReadLine();

                        Console.Write("USB Giriş Sayısı (2 veya 4): ");
                        pc.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Bluetooth var mı? (true/false): ");
                        pc.BluetoothVarMi =Convert.ToBoolean(Console.ReadLine());

                        pc.UrunAdiGetir();
                        pc.BilgileriYazdır();

                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 giriniz.");
                        continue;
                }

               

                // Devam etmek isteyip istemediğini sor
                Console.WriteLine("Başka bir ürün üretmek istiyor musunuz? Evet ya da Hayır olarak belirtiniz.");
                string yanit = Console.ReadLine().Trim().ToLower();

                makineSecimi = yanit == "e" || yanit == "evet";
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }

        Console.WriteLine("İyi günler dileriz.");
    }
}