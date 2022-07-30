using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpProje
{
    public class KagitKutusu : IDolabilen, IAtikKutusu
    {
        int _Kapasite;
        int _DoluHacim;

        public int Kapasite { get { return _Kapasite; } set { _Kapasite = value; } }

        public int DoluHacim { get { return _DoluHacim; } set { _DoluHacim = value; } }

        public int BosaltmaPuani { get { return 1000; } }

        public bool Bosalt()
        {
            return (DoluHacim > (Kapasite * 3 / 4));
        }

        public bool Ekle(IAtik atik1, IAtik atik2)
        {
            return ((Kapasite - DoluHacim) >= atik1.Hacim) && ((Kapasite - DoluHacim) >= atik2.Hacim);
        }
    }
}
