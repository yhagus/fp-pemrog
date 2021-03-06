﻿using System;
using System.Collections.Generic;

namespace SistemAbsensi
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Nama = "bagus";
            mahasiswa.NIM = "19";
            mahasiswa.Prodi = "if";
            mahasiswa.Kelas = "s1if02";
            mahasiswa.sks = 24;
            login.daftarData.Add(mahasiswa);
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
