using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SistemAbsensi
{
    class Login
    {
        public List<Data> daftarData = new List<Data>();
        
        public void AdminDashboard()
        {
            Console.Clear();

            Console.WriteLine("\n\t\tSistem Manajemen Mahasiswa\n");
            Console.WriteLine("\n1. Tambah Data Mahasiswa Baru");
            Console.WriteLine("\n2. Hapus Data Mahasiswa");
            Console.WriteLine("\n3. Tampilkan Data Mahasiswa");
            Console.WriteLine("\n0. Exit");
            Console.Write("\nPilihan anda [1-3] : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    Mahasiswa mahasiswa = new Mahasiswa();

                    Console.Write("Nama\t: ");
                    mahasiswa.Nama= Console.ReadLine();
                    Console.Write("NIM\t: ");
                    mahasiswa.NIM = Console.ReadLine();
                    Console.Write("Prodi\t: ");
                    mahasiswa.Prodi = Console.ReadLine();
                    Console.Write("Kelas\t: ");
                    mahasiswa.Kelas = Console.ReadLine();
                    Console.Write("SKS\t: ");
                    mahasiswa.sks = Convert.ToDouble(Console.ReadLine());

                    daftarData.Add(mahasiswa);

                    Console.WriteLine("Data mahasiswa berhasil ditambahkan");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Hapus data mahasiswa");
                    Console.Write("NIM\t: ");
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
                            Console.WriteLine("{0}.NIM\t\t: {1}\n  Nama\t\t: {2}\n  prodi\t\t: {3}\n  Kelas\t\t: {4}\n  SKS\t\t: {5}\n  Absensi\t: {6}\n",
                                i, mhs.NIM, mhs.Nama, mhs.Prodi, mhs.Kelas, mhs.SKS(),mhs.Absensi);
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
            Console.WriteLine("\n\t\tSilakan input presensi manual\n");
            Console.Write("Masukkan NIM anda : ");
            string inputnim = Console.ReadLine();
            foreach (Mahasiswa mhs in daftarData)
            {
                if (mhs.NIM == inputnim)
                {
                    mhs.Absensi = "Sudah presensi";
                    Console.WriteLine("Mahasiswa dengan NIM {0} berhasil presensi", inputnim);
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Mahasiswa dengan NIM {0} tidak ditemukan", inputnim);
            Console.ReadKey();
            return;

        }
    }
    
}
