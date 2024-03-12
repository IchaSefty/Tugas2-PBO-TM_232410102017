using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_2_TM
{
    internal class Ikan
    {
        public string nama;
        public string warna;
        public int berat;
    }
    class IkanBertulangRawan : Ikan
    {
        public void setIkanBertulangRawan (string nama, string warna, int berat)
        {
            this.nama = nama;
            this.warna = warna;
            this.berat = berat;
            
        }
        public (string, string, int) getIkanBertulangRawan()
        {
            return (nama, warna, berat);
        }
    }
}
