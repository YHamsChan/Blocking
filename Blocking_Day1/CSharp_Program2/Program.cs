using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Virus Virus1 = new Virus();
        Trojan Trojan1 = new Trojan();
        Worm Worm1 = new Worm();

        Virus1.Nama = "Sality32.exe";
        Virus1.size = 32;
        Virus1.banyak = 10;
        Virus1.kemampuan = "Menghapus file penting";
        Virus1.Menyerang();
        Virus1.MemperbanyakDiri();

        Trojan1.Nama = "BackdoorWin32.exe";
        Trojan1.kemampuan = "Shutdown Setiap 30 Menit";
        Trojan1.Menyerang();
        Trojan1.MenyembunyikanFile();

        Worm1.Nama = "Brontox.exe";
        Worm1.size = 14;
        Worm1.kemampuan = "Sleep setiap 15 menit";
        Worm1.Menyerang();
        Worm1.MenginfeksiRegistry();
        Worm1.MenghapusNTLDR();
    }
}
