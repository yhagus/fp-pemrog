using System;
using System.Collections.Generic;
using System.Text;

namespace SistemAbsensi
{
    abstract public class Data
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public string Prodi { get; set; }
        public string Kelas { get; set; }
        public string Absensi = "Belum presensi";
    }
    class Mahasiswa : Data
    {

    }
    
}
