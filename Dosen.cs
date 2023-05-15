using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosenApp
{
    public class Dosen
    {
        public string Matakuliah { get; set; }
        public string Nama { get; set; }
        public int Nik { get; set; }

        public Dosen()
        {
            // constructor untuk mengeset nik dan nama dosen pengampu matakuliah Pemrograman
            this.Nik = 05250xxxxx;
            this.Nama = "Kamarudin, M.Kom";
            this.Matakuliah = "Pemrograman";
        }

        public void SetDosen(int nik, string nama)
        {
            // method input nama dosen dan niknya
            this.Nik = nik;
            this.Nama = nama;
        }

        public void SetMatakuliah(string matakuliah)
        {
            // method input nama matakuliah
            this.Matakuliah = matakuliah;
        }
    }
}
