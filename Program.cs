using System;
using System.Collections.Generic;

class Program
{
    static String batas = "=====================================================================================";

    static void Main(string[] args)
    {
        int index = 0;
        int id = 0;
        String choice = "X";

        List<People> personList = new List<People>();
        personList.Add(new People() { Name = "Tes Dulu", Id = 1, Username = "tedu", Password = "123" });
        personList.Add(new People() { Name = "Tes Lagi", Id = 2, Username = "tela", Password = "123" });

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
                        AddData(personList, choice, id);
                        goto start;
                    }
                case 2:
                    {
                        ShowData(personList);
                        ContinueCode();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
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
        String[] menu = new string[5] { "Create User", "Show User", "Search", "Login", "Exit" };
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

    static void AddData(List<People> peopleList, String choice, int id)
    {
        do
        {
            Console.Clear();
            Banner("Tambah Data");
            do
            {
                for (int a = 0; a < peopleList.Count; a++)
                {
                    Console.Write("Input ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (peopleList[a].Id != id)
                    {
                        choice = "V";
                        Console.WriteLine(choice);
                        break;
                    }
                    else
                    {
                        choice = "X";
                        Console.WriteLine("ID Sudah ada");
                        Console.WriteLine();
                        Console.WriteLine(choice);
                        continue;
                    }
                }
            } while (choice == "X");
            Console.Write("Input First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input Password: ");
            String password = Console.ReadLine();
            String fullName = $"{firstName} {lastName}";
            String username = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            peopleList.Add(new People() { Id = id, Name = fullName, Username = username.ToLower(), Password = password });
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine($"{firstName} {lastName} telah ditambahkan");
            Console.WriteLine();
            Console.WriteLine("Tambah Produk lagi? (Y/N)");
            choice = Console.ReadLine();
        } while (choice.ToUpper() == "Y");
    }

    static void ShowData(List<People> personList)
    {
        Console.Clear();
        Banner("Data User");
        Console.WriteLine($"{null,3} ID {null,5} {null,10}  Name {null,10} {null,5} Username {null,5} {null,8} Password {null,5} ");
        //Console.WriteLine($"{null,3} __ {null,5} {null,10}  ____ {null,10} {null,5} ________ {null,5} {null,8} ________ {null,5} ");
        Console.WriteLine();
        foreach (People person in personList)
        {
            Console.WriteLine($"{person}");
        }
        Console.WriteLine();
        Console.WriteLine($"{batas}");
        Console.WriteLine();
    }
}

