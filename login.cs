using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SistemAbsensi
{
    class Login
    {
        List<Data> daftarData = new List<Data>();
        public string adminID = "admin";
        public string adminPassword = "admin";
        
        public void AdminDashboard()
        {
            Console.Clear();
            Console.WriteLine("\n\t1. Tambah Data Mahasiswa Baru");
            Console.WriteLine("\n\t2. Hapus Data Mahasiswa");
            Console.WriteLine("\n\t3. Tampilkan Data Mahasiswa");
            Console.WriteLine("\n\t0. Exit");

            int pilihan = Convert.ToInt32(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Mahasiswa mahasiswa = new Mahasiswa();

                    Console.Write("Nama : ");
                    mahasiswa.Nama= Console.ReadLine();
                    Console.Write("NIM : ");
                    mahasiswa.NIM = Console.ReadLine();
                    Console.Write("Prodi : ");
                    mahasiswa.Prodi = Console.ReadLine();
                    Console.Write("Kelas : ");
                    mahasiswa.Kelas = Console.ReadLine();

                    daftarData.Add(mahasiswa);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Hapus data mahasiswa");
                    Console.Write("NIM : ");
                    string inputnim = Console.ReadLine();

                    if (daftarData.Any(i => i.NIM == inputnim))
                    {
                        daftarData.RemoveAll(j => j.NIM == inputnim);
                        Console.WriteLine("Mahasiswa dengan NIM {0} telah dihapus", inputnim);
                    }
                    else
                    {
                        Console.WriteLine("Mahasiswa dengan NIM {0} tidak ditemukan", inputnim);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n");
                    int i = 1;
                    foreach (Mahasiswa mhs in daftarData)
                    {
                            Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                                i, mhs.NIM, mhs.Nama, mhs.Prodi, mhs.Kelas, mhs.Absensi);
                            i++;
                    }

                    Console.WriteLine("\nTekan enter untuk kembali ke menu");
                    Console.ReadKey();
                    break;
                case 0:
                    return;
            }
        }
        public void MahasiswaDashboard()
        {
            Console.Clear();
            Console.WriteLine("Silakan presensi");
            Console.WriteLine("Masukkan NIM anda: ");
            string inputnim = Console.ReadLine();
            if (daftarData.Any(i => i.NIM == inputnim))
            {
                
            }

        }
        public void AdminLogin(string username, string password)
        {
            Login login = new Login();
            if (username == login.adminID && password == login.adminPassword)
            {
                Console.WriteLine("\tBerhasil login");
                Console.ReadKey();
                login.AdminDashboard();
            }
            else
            {
                Console.WriteLine("\tUsername atau password salah");
            }
        }
    }
    
}
