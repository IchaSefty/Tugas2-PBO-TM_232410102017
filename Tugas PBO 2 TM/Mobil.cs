using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_2_TM
{
    internal class Mobil
    {
        public string nama;
        public string warna;
        public int tahunkeluaran;

    }

    class Mobilsedan : Mobil
    {
        public void setMobilsedan(string nama, string warna, int tahunkeluaran)
        {
            this.nama = nama;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
        }
        public (string, string, int) getMobilsedan()
        {
            return (nama, warna, tahunkeluaran);
        }
    }
}
