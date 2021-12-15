using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAuthMccG3
{
    public class Menu
    {
        public void Menuutama()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("             SELAMAT DATANG BOUS          ");
            Console.WriteLine("               MAU PESAN APA?             ");
            Console.WriteLine("===================================================");
            Console.WriteLine("");
            Console.WriteLine("         Menu Pilihan Makananan dan Minuman: ");
            Console.WriteLine("         1. Makanan ");
            Console.WriteLine("         2. Minuman");
            Console.WriteLine("         3. Pemesanan");
            Console.WriteLine("");
            Console.WriteLine("         Masukan Pilihan Anda : ");
            int pilih = int.Parse(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    if (pilih == 1)
                    {
                        Console.Clear();
                        Datamakanan datamakanan = new Datamakanan();
                        datamakanan.Daftarmakanan();
                        Console.WriteLine("");
                        Console.WriteLine("======================");
                        Console.WriteLine("2. Menu Minuman :  ");
                        Console.WriteLine("3. Pemesanan :");
                        Console.WriteLine("Masukan Pilihan :    ");
                        int pilihan = int.Parse(Console.ReadLine());
                        if (pilihan == 2)
                        {
                            Console.Clear();
                            Dataminuman dataminuman = new
                            Dataminuman();
                            dataminuman.Daftarminuman();

                            Console.WriteLine("");
                            Console.WriteLine("Apakah anda ingin memesan (y/n?   ");
                            string mesan = Console.ReadLine();
                            if (mesan == "y")
                            {
                                Console.Clear();
                                Pemesanan pemesanan = new Pemesanan();
                                pemesanan.pesan();
                            }
                            else if (mesan == "n")
                            {
                                Console.Clear();
                            }

                        }
                        else if (pilihan == 3)
                        {
                            Console.Clear();
                            Pemesanan pemesanan = new Pemesanan();
                            pemesanan.pesan();
                        }
                        else
                        {
                            Console.WriteLine("Inputan salah!");
                        }
                    }
                    break;
                case 2:
                    if (pilih == 2)
                    {
                        Console.Clear();
                        Dataminuman dataminuman = new Dataminuman();
                        dataminuman.Daftarminuman();
                        Console.WriteLine("Masukan Pilihan Anda 1 untuk melihat makanan dan 3 untuk memesan: ");
                        int pilihan = int.Parse(Console.ReadLine());

                        if (pilihan == 1)
                        {
                            Datamakanan datamakanan = new
                            Datamakanan();
                            datamakanan.Daftarmakanan();
                        }
                        else if (pilihan == 3)
                        {
                            Console.Clear();
                            Pemesanan pemesanan = new Pemesanan();
                            pemesanan.pesan();
                        }
                    }
                    break;

                case 3:
                    if (pilih == 3)
                    {
                        Console.Clear();
                        Pemesanan pemesanan = new Pemesanan();
                        pemesanan.pesan();
                    }
                    break;
            }
        }

        }
}
