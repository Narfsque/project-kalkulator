using System;

class Calculator
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 6;

        // Tugas 4: Melengkapi fungsi Main untuk menampilkan hasil
        Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
        Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
        Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }

    // Tugas 2: Menambahkan fungsi Penambahan
    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    // Tugas 3: Menambahkan fungsi Pengurangan
    static int Pengurangan(int a, int b)
    {
        return a - b;
    }

    // Tambahan agar kalkulator lengkap:
    static int Perkalian(int a, int b)
    {
        return a * b;
    }

    static int Pembagian(int a, int b)
    {
        return a / b;
    }
}