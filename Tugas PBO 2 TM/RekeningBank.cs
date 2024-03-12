using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_2_TM
{
    internal class RekeningBank
    {
        public string namapemilik;
        public int nomorrekening;
    }
    class RekeningGiro : RekeningBank
    {
        public void setRekeningGiro(string namapemilik, int nomorrekening)
        {
            this.namapemilik = namapemilik;
            this.nomorrekening = nomorrekening;
        }
        public (string,int) getRekeningGiro ()
        {
            return (namapemilik, nomorrekening);
        }
    }
    class RekeningKoran : RekeningBank
    {
        public void setRekeningKoran(string namapemilik, int nomorrekening)
        {
            this.namapemilik = namapemilik;
            this.nomorrekening = nomorrekening;
        }
        public (string, int) getRekeningKoran()
        {
            return (namapemilik, nomorrekening);
        }
    }
}
