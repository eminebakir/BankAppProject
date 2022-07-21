namespace Bankav1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.adi = "aykut";
            m1.soyadi = "taşdelen";
            m1.telefon_no = "0524394353";
            m1.musteri_no = "746373";
            m1.adresi = "ataköy 5. kısım";

            Musteri m2 = new Musteri();
            m2.adi = "miray";
            m2.soyadi = "taşdelen";
            m2.telefon_no = "052339563831";
            m2.musteri_no = "983982363";
            m2.adresi = "üsküdar";

            BankaHesabi hsp1 = new BankaHesabi(m1);

            hsp1.ParaYatirma(500);
            hsp1.ParaCekme(100);

            BankaHesabi hsp2 = new BankaHesabi(m2);

            hsp2.ParaYatirma(1000);
            hsp2.ParaCekme(500);
            hsp2.HesapOzeti();

        }
    }


}

