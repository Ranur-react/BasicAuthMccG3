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
        List<People> personList = new List<People>();
        personList.Add(new People() { Name = "Avatar Roku", Id = 1, Username = "avro", Password = "123" });
        personList.Add(new People() { Name = "Naruto Uzumaki", Id = 2, Username = "nauz", Password = "123" });

    start:
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
                        User.AddData(personList, choice);
                        goto start;
                    }
                case 2:
                    {
                        Console.Clear();
                        Banner("Data User");
                        User.ShowData(personList);
                        Console.WriteLine($"{batas}");
                        ContinueCode();
                        goto start;
                    }
                case 3:
                    {
                        Console.Clear();
                        Banner("Hapus Data");
                        User.DeleteData(personList, choice);
                        goto start;
                    }
                case 4:
                    {
                        Console.Clear();
                        Banner("Cari Data");
                        User.SearchData(personList, batas);
                        ContinueCode();
                        goto start;
                    }
                case 5:
                    {
                        Console.Clear();
                        Banner("Login Page");
                        User.LoginPage(personList);
                        ContinueCode();
                        goto start;
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
        finally
        {
            Console.Clear();
            MainMenu();
            Console.WriteLine();
        }
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
    }

    static void ContinueCode()
    {
        Console.WriteLine();
        Console.WriteLine("press any key to continue");
        String next = Console.ReadLine();
        Console.Clear();
    }
}

