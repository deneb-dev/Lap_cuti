using System;

namespace Lap_cuti
{
    class Program 
    {
        static void Main(String[] args)
        {
            Formlogin formlogin = new Formlogin();
            formlogin.showLoginkonsol();

            Console.WriteLine(formlogin.getResponLogin());

        
            Inputdata karyawan = new Inputdata();
            int i = 1;
            while ( i <= 2)
            {
                int pilih;
                Console.WriteLine("\n\tAplikasi Laporan Cuti Kayawan");
                Console.WriteLine("=======================================");
                Console.WriteLine("\t1. Tambah Data Cuti\n\t2. Cetak Data Cuti\n\t3. Keluar\n=======================================");
                Console.Write("Pilih : ");

                pilih = int.Parse(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        {
                            karyawan.InputKaryawan();
                            break;
                        }
                    case 2:
                        {
                            karyawan.showKaryawan();
                            break;
                        }
  
                    default :
                        {
                            Console.WriteLine("Terima Kasih Selamat Berlibur :)");
                            break;
                        }
                }

            }

            

        }
          


    }
        
    }