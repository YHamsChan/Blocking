using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Trojan : Malware
    {
        public void MenyembunyikanFile()
        {
            Console.WriteLine("Menyembunyikan file yang ada di C:/Program File/Microsoft Office");
        }
        public void MemblokirCMD()
        {
            Console.WriteLine("Blokir semua aktifitas yang menggunakan Command Prompt");
        }
    }
}