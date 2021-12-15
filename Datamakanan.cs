using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAuthMccG3
{
    public class Datamakanan : Menu // Datamakanan Child
    {
        public void Daftarmakanan()
        {
            Console.WriteLine("DAFTAR MAKANAN :");
            List<string> namamakanan = new List<String>();
            namamakanan.Add("1. Nasi Goreng     RP. 20000");
            namamakanan.Add("2. Mie Goreng      RP. 15000");
            namamakanan.Add("3. Capcay          RP. 13000 ");
            namamakanan.Add("4. Sate Padang     RP. 18000");
            List<string> mak = namamakanan.ToList();
            mak.ForEach(Console.WriteLine);
        }
    }
}
