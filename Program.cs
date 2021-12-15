using System;
using System.Collections.Generic;

class Program
{
    static String batas = "=====================================================================================";
    static People user = new People();
    static void Main(string[] args)
    {
        int index = 0;
        String choice = "X";


        List<People> personList = new List<People>();

        Console.Clear();
        MainMenu();
        try
        {
            Console.Write("Masukkan pilihan: ");
            index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:

                    Console.Clear();
                    Banner("Tambah Data");
                    user.AddData(choice);
                    break;
                case 2:
                    Console.Clear();
                    Banner("Data User");
                    user.ShowData(personList);
                    Console.WriteLine($"{batas}");
                    ExecActions(ChoiceActionsCode());
                    break;

                case 3:

                    Console.Clear();
                    Banner("Hapus Data");
                    user.DeleteFunctions();
                    ContinueCode();
                    break;

                case 4:
                    Console.Clear();
                    Banner("Cari Data");
                    user.SearchFunctions();
                    ContinueCode();
                    break;
                case 5:
                    Console.Clear();
                    Banner("Login Page");
                    user.LoginPage(personList);
                    ContinueCode();
                    break;
                case 6:
                    {
                        return;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Menu tidak ditemukan / Input Salah");
                    Console.WriteLine();
                    ContinueCode();
                    break;
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

    private static void ExecActions(string v)
    {

        if (v.ToLower() == "d")
        {
            //Delete Method calling here
            user.DeleteFunctions();

        }
        else if (v.ToLower() == "u")
        {
            //Update Method calling here
            user.UpdateFunctions();
        }
        else
        {
            ContinueCode();
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


    public static String ChoiceActionsCode()
    {
        String next = "Q";
        Console.WriteLine();
        Console.WriteLine("Select Actions ?   \n\t~[ D: Delete U:Update, Q: Exit]");
        next = Console.ReadLine();
        return next;
    }
}

