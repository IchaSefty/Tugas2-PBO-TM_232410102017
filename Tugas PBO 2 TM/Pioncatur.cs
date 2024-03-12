using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_2_TM
{
    internal class Pioncatur
    {
        public int jumlah;
        public string gerak;
    }
    class King : Pioncatur
    {
        public void setKing(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getKing()
        {
            return (jumlah, gerak);
        }
    }
    class Queen : Pioncatur
    {
        public void setQueen(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getQueen()
        {
            return (jumlah, gerak);
        }
    }
    class Gajah : Pioncatur
    {
        public void setGajah(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getGajah()
        {
            return (jumlah, gerak);
        }
    }
    class Knight : Pioncatur
    {
        public void setKnight(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getKnight()
        {
            return (jumlah, gerak);
        }
    }
    class Rook : Pioncatur
    {
        public void setRook(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getRook()
        {
            return (jumlah, gerak);
        }
    }
    class Pawn : Pioncatur
    {
        public void setPawn(int jumlah, string gerak)
        {
            this.jumlah = jumlah;
            this.gerak = gerak;
        }
        public (int, string) getPawn()
        {
            return (jumlah, gerak);
        }
    }
}

