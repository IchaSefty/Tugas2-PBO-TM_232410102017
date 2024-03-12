// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Tugas_PBO_2_TM
{
    class Akses
    {
        static void Main(string[] args)
        {
            Mobilsedan hondacity = new Mobilsedan();
            hondacity.setMobilsedan("Honda City Hatchback", "Orange", 2021);
            (string, string, int) valueshondacity = hondacity.getMobilsedan();
            string hondacitya = valueshondacity.Item1;
            string hondacityb = valueshondacity.Item2;
            int hondacityc = valueshondacity.Item3;
            Console.WriteLine($"Mobil");
            Console.WriteLine($"Mobil Sedan");
            Console.WriteLine($"Nama Mobil Sedan    : " + hondacitya );
            Console.WriteLine($"Warna Mobil Sedan   : " + hondacityb );
            Console.WriteLine($"Keluaran Tahun      : " + hondacityc);
            Console.WriteLine($"");

            IkanBertulangRawan pari = new IkanBertulangRawan();
            pari.setIkanBertulangRawan("Ikan Pari", "Abu-abu", 1);
            (string, string, int) valuespari = pari.getIkanBertulangRawan();
            string apari = valuespari.Item1;
            string bpari = valuespari.Item2;
            int cpari = valuespari.Item3;
            Console.WriteLine($"Ikan");
            Console.WriteLine($"Ikan Bertulang Rawan");
            Console.WriteLine($"Nama Ikan Bertulang Rawan   : " + apari);
            Console.WriteLine($"Warna Ikan                  : " + bpari);
            Console.WriteLine($"Berat Ikan                  : " + cpari + "Ton");
            Console.WriteLine($"");

            King raja = new King();
            raja.setKing(1, "Dapat melangkah satu petak secara horizontal, vertikal, ataupun diagonal");
            (int, string) valuesraja = raja.getKing();
            int araja = valuesraja.Item1;
            string braja = valuesraja.Item2;
            Console.WriteLine($"Pion Catur");
            Console.WriteLine($"King");
            Console.WriteLine($"Jumlah   : " + araja);
            Console.WriteLine($"Gerak    : " + braja);
            Console.WriteLine($"");

            Queen menteri = new Queen();
            menteri.setQueen(1, "Melangkah bebas ke atas dan kebawah dalam lajur apapun serta ke kiri dan ke kanan pada baris apapun ");
            (int, string) valuesmenteri = menteri.getQueen();
            int amenteri = valuesmenteri.Item1;
            string bmenteri = valuesmenteri.Item2;
            Console.WriteLine($"Queen");
            Console.WriteLine($"Jumlah   : " + amenteri);
            Console.WriteLine($"Gerak    : " + bmenteri);
            Console.WriteLine($"");

            Gajah gajah = new Gajah();
            gajah.setGajah(2, "Bergerak secara diagonal sebanyak petak yang diinginkan selama tidak terhalang oleh buahnya sendiri");
            (int, string) valuesgajah = gajah.getGajah();
            int agajah = valuesgajah.Item1;
            string bgajah = valuesgajah.Item2;
            Console.WriteLine($"Gajah");
            Console.WriteLine($"Jumlah   : " + agajah);
            Console.WriteLine($"Gerak    : " + bgajah);
            Console.WriteLine($"");

            Knight kuda = new Knight();
            kuda.setKnight(2, "Dapat melompati buah lain");
            (int, string) valueskuda = kuda.getKnight();
            int akuda = valueskuda.Item1;
            string bkuda = valueskuda.Item2;
            Console.WriteLine($"Knight");
            Console.WriteLine($"Jumlah   : " + akuda);
            Console.WriteLine($"Gerak    : " + bkuda);
            Console.WriteLine($"");

            Rook benteng = new Rook();
            benteng.setRook(2, "Dapat melangkah seperti tanda +");
            (int, string) valuesbenteng = benteng.getRook();
            int abenteng = valuesbenteng.Item1;
            string bbenteng = valuesbenteng.Item2;
            Console.WriteLine($"Rook");
            Console.WriteLine($"Jumlah   : " + abenteng);
            Console.WriteLine($"Gerak    : " + bbenteng);
            Console.WriteLine($"");

            Pawn pion = new Pawn();
            pion.setPawn(8, "Menyerang setiap petak secara diagonal ke kiri atau ke kanan");
            (int, string) valuespion = pion.getPawn();
            int apion = valuespion.Item1;
            string bpion = valuespion.Item2;
            Console.WriteLine($"Pawn");
            Console.WriteLine($"Jumlah   : " + apion);
            Console.WriteLine($"Gerak    : " + bpion);
            Console.WriteLine($"");

            RekeningGiro BRI = new RekeningGiro();
            BRI.setRekeningGiro("Syasa Istiana", 458989847);
            (string, int) valuesBRI = BRI.getRekeningGiro();
            string aBRI = valuesBRI.Item1;
            int bBRI = valuesBRI.Item2;
            Console.WriteLine("Rekening Bank");
            Console.WriteLine($"Rekening Giro");
            Console.WriteLine($"Nama Pemilik   : " + aBRI);
            Console.WriteLine($"Nomor Rekening : " + bBRI);
            Console.WriteLine($"");

            RekeningKoran BCA = new RekeningKoran();
            BCA.setRekeningKoran("Jamal Ananta", 231404028);
            (string, int) valuesBCA = BCA.getRekeningKoran();
            string aBCA = valuesBCA.Item1;
            int bBCA = valuesBCA.Item2;
            Console.WriteLine($"Rekening Koran");
            Console.WriteLine($"Nama Pemilik   : " + aBCA);
            Console.WriteLine($"Nomor Rekening : " + bBCA);

        }


    }

}


