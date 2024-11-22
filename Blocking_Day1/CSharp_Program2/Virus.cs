using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class  Virus : Malware
    {
        public int banyak;
        public void MemperbanyakDiri()
        {
            Console.WriteLine("{0} memperbanyak diri sebanyak {1} kali.", this.Nama, this.banyak*5);
        }
    }
}