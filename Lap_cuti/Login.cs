using System;
using System.Collections.Generic;
using System.Text;

namespace Lap_cuti
{
    class Login
    {
        //public string judulform = "====login user====";
        public String username;
        public String password;
      
        /*  Method Proses Login
         */
        public bool LoginBerhasil()
        {
            if(this.username == "user" && this.password == "1234")
            {
                return true;
            }
            return false;
        }

        public String getResponLogin()
        {
            return (this.LoginBerhasil()) ? "Login Berhasil, Selamat Datang " + this.username : "Login Gagal";
        }
    }
}
