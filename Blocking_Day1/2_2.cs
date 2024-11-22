using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan jari-jari lingkaran: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double luas = Math.PI * r * r;
        double keliling = 2 * Math.PI * r;
        Console.WriteLine($"Luas lingkaran: {luas}");
        Console.WriteLine($"Keliling lingkaran: {keliling}");
    }
}
