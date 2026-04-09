using System;

namespace KalkulatorSederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                // Identitas Pemilik
                Console.WriteLine("========================================");
                Console.WriteLine("        PROGRAM KALKULATOR C#           ");
                Console.WriteLine("========================================");
                Console.WriteLine(" Nama : Hudam Narof");
                Console.WriteLine(" NIM  : 25.11.6563");
                Console.WriteLine("========================================\n");

                try
                {
                    // Input angka pertama
                    Console.Write("Masukkan angka pertama: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Input operator
                    Console.Write("Masukkan operator (+, -, *, /): ");
                    string op = Console.ReadLine();

                    // Input angka kedua
                    Console.Write("Masukkan angka kedua: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;
                    bool valid = true;

                    // Logika perhitungan
                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("\nError: Tidak bisa membagi dengan nol!");
                                valid = false;
                            }
                            break;
                        default:
                            Console.WriteLine("\nError: Operator tidak valid!");
                            valid = false;
                            break;
                    }

                    if (valid)
                    {
                        Console.WriteLine("\n----------------------------------------");
                        Console.WriteLine($"Hasil: {num1} {op} {num2} = {result}");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Mohon masukkan angka yang valid!");
                }

                // Opsi keluar
                Console.Write("\nIngin menghitung lagi? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                {
                    running = false;
                    Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini, Hudam!");
                }
            }
        }
    }
}