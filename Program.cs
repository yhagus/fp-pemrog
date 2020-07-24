using System;
using System.Collections.Generic;

namespace SistemAbsensi
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tAplikasi Sistem Absensi Manual Mahasiswa\n");
                Console.WriteLine("1. Login sebagai admin");
                Console.WriteLine("2. Presensi sebagai mahasiswa");
                Console.WriteLine("0. Exit");
                Console.Write("\nPilihan anda [1-2]: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        /*
                        Console.Clear();
                        Console.Write("Username : ");
                        string username = Console.ReadLine();
                        Console.Write("Password : ");
                        string password = Console.ReadLine();
                        login.AdminLogin(username, password);
                        */
                        login.AdminDashboard();
                        break;
                    case 2:
                        login.MahasiswaDashboard();
                        break;
                    case 0: return;
                }
            }
        }
    }
}
