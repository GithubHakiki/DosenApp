using DosenApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        Dosen dosen = new Dosen();

        Console.WriteLine("NIK: {0}", dosen.Nik);
        Console.WriteLine("Nama: {0}", dosen.Nama);
        Console.WriteLine("Mata Kuliah: {0}", dosen.Matakuliah);

        Console.WriteLine("\nInput NIK Dosen:");
        int nik = int.Parse(Console.ReadLine());

        Console.WriteLine("Input Nama Dosen:");
        string nama = Console.ReadLine();

        dosen.SetDosen(nik, nama);

        Console.WriteLine("Input Matakuliah:");
        string matakuliah = Console.ReadLine();

        dosen.SetMatakuliah(matakuliah);

        Console.WriteLine("\nNIK: {0}", dosen.Nik);
        Console.WriteLine("Nama: {0}", dosen.Nama);
        Console.WriteLine("Matakuliah: {0}", dosen.Matakuliah);

        Console.ReadKey();
    }
}