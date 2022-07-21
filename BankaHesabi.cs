
namespace Bankav1
{
    public class BankaHesabi
    {
        #region Veri Elamanları
        protected string iban;
        protected int bakiye;
        protected Musteri mudi;
        protected DateTime acilisTarihi;
        #endregion

        #region Property'ler
        public string Iban
        {
            get { return iban; }
        }

        public decimal Bakiye
        {
            get { return bakiye; }
        }

        public Musteri Mudi
        {
            get { return mudi; }
        }

        public DateTime AcilisTarihi
        {
            get { return acilisTarihi; }
        }

        #endregion

        #region Fonksiyonlar

        public BankaHesabi()
        {
            this.iban = this.IbanUret();
            this.acilisTarihi = DateTime.Now;
            this.bakiye = 0;
        }

        public BankaHesabi(Musteri mudi) : this()
        {
            this.mudi = mudi;
        }

        private string IbanUret()
        {
            string ibanNo = "TR90 ";
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                ibanNo += random.Next(1000, 9999) + " ";
            }

            return ibanNo + "83";
        }

        public abstract void ParaYatirma(int miktar);
       
        public bool ParaCekme(int miktar)
        {
            if (miktar > bakiye)
            {
                Console.WriteLine("Cekmek istediginiz miktari bakiyeniz karsilamiyor");
                return false;
            }
            else if (miktar >= 30000)
            {
                Console.WriteLine("Gunluk cekim limiti!");
                return false;
            }
            else
            {
                bakiye -= miktar;
                Console.WriteLine("Paranizi gule gule harcayin");
                return true;
            }

        }

        public void HesapOzeti()
        {
            Console.WriteLine("Hesap özetini görmek istiyor musunuz ? [E | H] ");

            ConsoleKeyInfo cki = Console.ReadKey();

            if(cki.KeyChar == 'E' || cki.KeyChar == 'e')
            {
                Console.Clear();
                Console.WriteLine("======= Hesap Özeti =====");
                Console.WriteLine("Iban " + this.Iban);
                Console.WriteLine("Açılış Tarihi: " + this.acilisTarihi);
                Console.WriteLine("Kalan Hesap: " + this.Bakiye);
                Console.WriteLine("web");
            }
            else if (cki.KeyChar == 'E' || cki.KeyChar == 'e')
            {
                Console.WriteLine("Vazgeçildi");
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
        }

        #endregion
    }

    public class VadesizHesabi : BankaHesabi
    {
        public void ParaYatirma(int miktar)
        {
            bakiye += miktar;
        }

        public bool ParaCekme(int miktar)
        {
            if (miktar > bakiye)
            {
                Console.WriteLine("Cekmek istediginiz miktari bakiyeniz karsilamiyor");
                return false;
            }
            else if (miktar >= 30000)
            {
                Console.WriteLine("Gunluk cekim limiti!");
                return false;
            }
            else
            {
                bakiye -= miktar;
                Console.WriteLine("Paranizi gule gule harcayin");
                return true;
            }

        }

        public void HesapOzeti()
        {
            Console.WriteLine("Hesap özetini görmek istiyor musunuz ? [E | H] ");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.KeyChar == 'E' || cki.KeyChar == 'e')
            {
                Console.Clear();
                Console.WriteLine("======= Hesap Özeti =====");
                Console.WriteLine("Iban " + this.Iban);
                Console.WriteLine("Açılış Tarihi: " + this.acilisTarihi);
                Console.WriteLine("Kalan Hesap: " + this.Bakiye);
                Console.WriteLine("web");
            }
            else if (cki.KeyChar == 'E' || cki.KeyChar == 'e')
            {
                Console.WriteLine("Vazgeçildi");
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
        }

    }

    public class VadeliHesap : BankaHesabi
    {
        private int faizOrani;
        protected DateTime valorTarihi;

        public VadeliHesap(Musteri mudi, int faizOrani, DateTime valorTarihi) : base(mudi)
        {
            this.faizOrani = faizOrani;
            this.valorTarihi = valorTarihi;
        }

        public decimal GetiriHesapla()
        {
            return base.bakiye * this.faizOrani / 100 / 12;
        }
    }
}
