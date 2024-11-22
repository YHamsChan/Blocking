using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Worm : Malware
    {
        public void MenginfeksiRegistry()
        {
            Console.WriteLine("{0} menginfeksi registry.", this.Nama);
        }

        public void MenghapusNTLDR()
        {
            Console.WriteLine("{0} menghapus NT Loader.", this.Nama);
        }
    }
}