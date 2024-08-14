using System;
namespace Week4Final
{
    public abstract class BaseMakine
    {
        // Ortak özellikler
        public DateTime UretimTarihi { get; set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // Constructor ile üretim tarihi otomatik olarak atanır
        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        // Ortak bilgileri yazdıran metod. Hem bilgisayar hem de telefon için aynı olacak, virtual kullanıldı. 
        public virtual void BilgileriYazdır()
        {
            Console.WriteLine($"Cihazın genel bilgileri:\nÜretim Tarihi: {UretimTarihi}\nSeri Numarası: {SeriNumarasi}\nAd: {Ad}\nAçıklama: {Aciklama}\nİşletim Sistemi: {IsletimSistemi}");
        }

        // Her iki ürün için de gövdesi değişecek. Abstract seçildi, override ile kullanılacak.
        public abstract void UrunAdiGetir();
    }

    public class Telefon : BaseMakine
    {
        public bool TrLisansVarMi { get; set; }


        public override void BilgileriYazdır()
        {
            base.BilgileriYazdır();
            Console.WriteLine($"TR Lisans Durumu: {(TrLisansVarMi ? "Var" : "Yok")}");
        }


        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı: {Ad}");
        }
    }

    public class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi; // Encapsulation metodu

        public int UsbGirisSayisi
        {
            get
            {
                return _usbGirisSayisi;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGirisSayisi = value;
                }
                else
                {
                    Console.WriteLine("USB giriş sayısı 2 ya da 4 olabilir.");
                    _usbGirisSayisi = -1;
                }
            }
        }

        public bool BluetoothVarMi { get; set; }

        // Bilgileri yazdırma metodunu override eder
        public override void BilgileriYazdır()
        {
            base.BilgileriYazdır();
            Console.WriteLine($"Bluetooth Durumu: {(BluetoothVarMi ? "Var" : "Yok")}");
        }

        // Ürün adını yazdırma metodunu override eder
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı: {Ad}");
        }
    }
}
