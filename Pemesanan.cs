using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAuthMccG3
{
    public class Pemesanan : Menu //Pemesanan Child
    {
        public void pesan()
        {
            int Jumlah;
            do
            {
                Console.WriteLine("Masukan Jumlah Barang (1 .... 5 ):");
                Jumlah = int.Parse(Console.ReadLine());
            } while (Jumlah <= 1 || Jumlah > 5);

            //Looping dengan menggunakan kombinasi Array. Akan mencetak inputan nama barang dan harga barang
            string[] nama = new string[Jumlah];
            int[] harga = new int[Jumlah];
            int total = 0;
            int bayar, kembali;
            double discount = 0.10;
            double hargadiskon;
            double afterdiskon;

            for (int i = 0; i < Jumlah; i++)
            {
                do
                {
                    try
                    {
                        Console.Write("\nMasukkan nama barang Ke-" + (i + 1) + " [3..100 karakter] : ");
                        nama[i] = Console.ReadLine();

                    }

                    catch
                    {
                        Console.WriteLine("Inputan salah, Silahkan masukan huruf minimal 3-100 karakter");
                    }

                } while (nama[i].Length <= 3 || nama[i].Length >= 100);
                do
                {
                    try
                    {
                        Console.Write("Masukkan harga barang Ke-" + (i + 1) + " [1000...10000] : ");
                        harga[i] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Inputan salah, Silahkan masukan huruf minimal 3-100 karakter");
                    }

                } while (harga[i] <= 1000 || harga[i] >= 100000);
            }


            //Menampilkan list harga dan barang yang dibeli
            Console.Clear();
            Console.WriteLine("\n\nBarang yang dibeli");
            Console.WriteLine("=============================");
            for (int i = 0; i < Jumlah; i++)
            {
                Console.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
            }
            foreach (int i in harga)
            {
                total += i;
                if (total > 20000)
                {
                    hargadiskon = total * discount;
                    Console.WriteLine("=============================");
                    Console.WriteLine("diskon yang didapatkan    " + hargadiskon);
                    afterdiskon = (int)(total - hargadiskon);

                    Console.WriteLine("");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Harga belanjaan anda mendapatkan diskon sebesar 10%");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Harga setelah diskon    " + afterdiskon);
                }
                else if (total < 20000)
                {
                    Console.WriteLine("");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Harga yang harus di bayar    " + total);
                }

            }


            do
            {
                Console.Write("\n\nUang Bayar : ");
                bayar = int.Parse(Console.ReadLine());

                kembali = bayar - total;

                if (bayar < total)
                {
                    Console.WriteLine("Maaf, uang anda kurang !!");
                    Console.WriteLine("-------------------------");
                }
                //Jika kondisi bernilai benar (input uang bayar lebih besar dari total harga)
                else
                {
                    Console.WriteLine("\nUang kembalian anda Rp. " + kembali + ",00");
                }

            } while (bayar < total);

            Console.WriteLine("\n\n\t\t^^ Terimakasih telah berbelanja di toko kami ^^");

            Console.ReadLine();
        }
    }
}
