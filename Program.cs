using System;
using System.Collections.Generic;

class Program
{
    static String batas = "=====================================================================================";

    static void Main(string[] args)
    {
        int index = 0;
        String choice = "X";
        People User = new People();
        
        Console.Clear();
        MainMenu();
        try
       {
            Console.Write("Masukkan pilihan: ");
            index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:
                    {
                        Console.Clear();
                        Banner("Tambah Data");
                        User.AddData(choice);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Banner("Data User");
                        User.ShowData();
                        Console.WriteLine($"{batas}");
                        ContinueCode();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Banner("Hapus Data");
                        User.DeleteData(choice);
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Banner("Cari Data");
                        User.SearchData(batas);
                        ContinueCode();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Banner("Login Page");
                        User.LoginPage();
                        ContinueCode();
                        break;
                    }
                case 6:
                    {
                        return;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Menu tidak ditemukan / Input Salah");
                        Console.WriteLine();
                        ContinueCode();
                        break;
                    }
            }
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine($"Exception, {e.Message}");
            Console.WriteLine();
            ContinueCode();
            Main(args);
        }
        Main(args);
    }

    static void Banner(String title)
    {
        Console.WriteLine();
        Console.WriteLine($"{title,50}");
        Console.WriteLine();
        Console.WriteLine(batas);
        Console.WriteLine();
    }

    static void MainMenu()
    {
        String title = "Admin Page";
        String[] menu = new string[6] { "Create User", "Show User", "Hapus Data", "Search", "Login", "Exit" };
        Banner(title);
        for (int i = 0; i < menu.Length; i++)
        {
            Console.Write($"{i + 1,38}. {menu[i]}");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(batas);
        Console.WriteLine();
    }

    static void ContinueCode()
    {
        Console.WriteLine();
        Console.WriteLine("press enter to continue");
        String next = Console.ReadLine();
        Console.Clear();
    }
}

