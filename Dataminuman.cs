using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicAuthMccG3
{
    public class Dataminuman : Menu //Dataminuman Child
    {
        public void Daftarminuman()
        {
            Console.WriteLine("DAFTAR MINUMAN :");
            List<string> namamakanan = new List<String>();
            namamakanan.Add("1. Es Teh          Rp. 40000");
            namamakanan.Add("2. Nutrisari       Rp. 4000");
            namamakanan.Add("3. Josu            Rp. 6000");
            namamakanan.Add("4. Es Jeruk        Rp 8000");
            List<string> mak = namamakanan.ToList();
            mak.ForEach(Console.WriteLine);
        }
    }
}
