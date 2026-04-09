using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Identitas
        string nama = "Hudam Narof";
        string nim = "25.11.6563";

        // Menampilkan Header
        Console.WriteLine("========================================");
        Console.WriteLine("       PROGRAM KALKULATOR SEDERHANA      ");
        Console.WriteLine("========================================");
        Console.WriteLine($" Nama : {nama}");
        Console.WriteLine($" NIM  : {nim}");
        Console.WriteLine("========================================\n");

        // Input angka dari user agar lebih interaktif
        Console.Write("Masukkan angka pertama: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Masukkan angka kedua  : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----------------------------------------");
        
        // Menampilkan hasil dengan memanggil method
        Console.WriteLine(" HASIL PERHITUNGAN:");
        Console.WriteLine(" 1. Penambahan  : {0} + {1} = {2}", a, b, Penambahan(a, b));
        Console.WriteLine(" 2. Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
        Console.WriteLine(" 3. Perkalian   : {0} x {1} = {2}", a, b, Perkalian(a, b));
        Console.WriteLine(" 4. Pembagian   : {0} / {1} = {2}", a, b, Pembagian(a, b));
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
        Console.ReadKey();
    }

    // Method Penambahan
    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    // Method Pengurangan
    static int Pengurangan(int a, int b)
    {
        return a - b;
    }

    // Tambahan variasi: Method Perkalian
    static int Perkalian(int a, int b)
    {
        return a * b;
    }

    // Tambahan variasi: Method Pembagian (menggunakan float agar akurat)
    static string Pembagian(int a, int b)
    {
        if (b == 0) return "Error (Bagi Nol)";
        return ((float)a / b).ToString("0.00");
    }
}