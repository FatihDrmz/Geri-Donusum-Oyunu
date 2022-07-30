using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpProje
{
    public  class SalcaKutusu : IAtik
    {
        public int Hacim { get { return 550; } }

        public Image Image { get { return Image.FromFile("salcakutusu.png"); } }
    }
}
