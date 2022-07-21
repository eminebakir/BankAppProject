using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankav1
{
    public abstract class Musteri
    {
        public string adi;
        public string soyadi;
        public string musteri_no;
        public string adresi;
        public string telefon_no;

        public abstract void HesapAcmak();

        public abstract void ParaTransfer();

        public abstract void KendiHesabinaParaYatirma();

        public abstract void KendiHesabindanParaCekme();
 
    }

    class BireyselMusteri : Musteri
    {
        public override void HesapAcmak()
        {
            throw new NotImplementedException();
        }

        public override void KendiHesabinaParaYatirma()
        {
            throw new NotImplementedException();
        }

        public override void KendiHesabindanParaCekme()
        {
            throw new NotImplementedException();
        }

        public override void ParaTransfer()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class KurumsalMusteri : Musteri
    {
        public string Sirketİsmi { get; set; }
        public string SirketAdresi { get; set; }

        public override void HesapAcmak()
        {
            throw new NotImplementedException();
        }

        public override void KendiHesabinaParaYatirma()
        {
            throw new NotImplementedException();
        }

        public override void KendiHesabindanParaCekme()
        {
            throw new NotImplementedException();
        }

        public override void ParaTransfer()
        {
            throw new NotImplementedException();
        }
    }
}
