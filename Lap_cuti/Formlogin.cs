using System;
using System.Collections.Generic;
using System.Text;

namespace Lap_cuti
{
    class Formlogin : Login
    {
       
        public String title = "APLIKASI LAPORAN CUTI";

      public void showLoginkonsol()
        {
            Console.SetCursorPosition((Console.WindowWidth - this.title.Length) / 2, Console.CursorTop);
            Console.Write(this.title);
            Console.WriteLine();
            Console.Write("Username : ");
            this.username = Console.ReadLine();
            Console.Write("Password : ");
            this.password = Console.ReadLine();
        }
    }
}
