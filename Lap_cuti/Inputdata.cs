using System;
using System.Collections.Generic;
using System.Text;

namespace Lap_cuti
{
    class Inputdata
    {
        public String[] nrp;
        public String[] nama;
        public String[] departement;
        public String[] lokasiCab;
        public int c;

        public void InputKaryawan()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Jumlah Karyawan Cuti yang akan di input :");
            c = int.Parse(Console.ReadLine());

            nrp = new String[255];
            nama = new String[255];
            departement = new String[255];
            lokasiCab = new String[255];

            for (int i = 1; i <= c; i++)
            {
                Console.Write("\tNRP    = ", i + 1);
                nrp[i] = Console.ReadLine();
                Console.Write("\tNama Karyawan = ", i + 1);
                nama[i] = Console.ReadLine();

                Console.Write("\tDepartement = ", i + 1);
                departement[i] = Console.ReadLine();
                Console.Write("\tLokasi Cabang = ", i + 1);
                lokasiCab[i] = Console.ReadLine();
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("==============================================");

         }
        public void showKaryawan()
        {
            Console.WriteLine("================================================");
            for (int j = 1; j <= c; j++)
            {
                Console.WriteLine("\tNRP = {1}", j + 1, nrp[j]);
                Console.WriteLine("\tNama Karyawan = {1}", j + 1, nama[j]);
                Console.WriteLine("\tDepartement = {1}", j + 1, departement[j]);
                Console.WriteLine("\tLokasi Cabang = {1}", j + 1, lokasiCab[j]);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("========================================");

        }

    }
}

//public String merk;
//public String warna;


//public void maju()
//{
//    Console.WriteLine(" Mobil " +""+ this.merk + " Jalan Maju ");
//}