﻿using System;
using System.Collections.Generic;
using System.Linq;

public class People : IEquatable<People>
{
    public string Name { get; set; }

    public string Username { get; set; }

    public int Id { get; set; }

    public String Password { get; set; }
    private static List<People> peopleDatabase = new List<People>();

    public override string ToString()
    {
        return $"| {Id,5} | {Name,28} | {Username,20} | {Password,20} |";
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        People objAsPeople = obj as People;
        if (objAsPeople == null) return false;
        else return Equals(objAsPeople);
    }

    public override int GetHashCode()
    {
        int hashName = Name == null ? 0 : Name.GetHashCode();

        int hashId = Name.GetHashCode();

        return hashName ^ hashId;
    }
    public bool Equals(People other)
    {
        if (Object.ReferenceEquals(other, null)) return false;

        if (Object.ReferenceEquals(this, other)) return true;

        return Id.Equals(other.Id) && Name.Equals(other.Name);
    }
    public void AddData(String choice)
    {
        do
        {
            //harusnya pakai foreach biar inputan yang separo jalan tidak ditmabhakan di List
            var lastPerson = peopleDatabase.Count;
            int id = lastPerson + 1;
            Console.Write("Input First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input Password: ");
            String password = Console.ReadLine();
            String fullName = $"{firstName} {lastName}";
            String username = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            peopleDatabase.Add(new People() { Id = id, Name = fullName, Username = username.ToLower(), Password = password });
            choice = AskRepeatOrNot(firstName, lastName);
        } while (choice.ToUpper() == "Y");
    }

    private string AskRepeatOrNot(string firstName, string lastName)
    {
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine($"{firstName} {lastName} telah ditambahkan");
        Console.WriteLine();
        Console.WriteLine("Tambah Produk lagi? (Y/N)");
        return Console.ReadLine();
    }

    public void AddData(List<People> peopleList, String choice)
    {
        do
        {
            var lastPerson = peopleList[^1];
            int id = lastPerson.Id + 1;

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
    public void UpdateFunctions()
    {
        Console.Write("Masukan Id User yang mau Di Ubah : ");
        UpdateData(findIndex(Console.ReadLine()));
    }
    public void DeleteFunctions()
    {
        Console.Write("Masukan Id User yang mau Di Hapus : ");
        DeleteDataFromDatabasePeople(findIndex(Console.ReadLine()));
    }
    public void SearchFunctions()
    {
        Console.Write("Masukan Parameter pencarian : ");
        int indexSearch = findIndexSearch(Console.ReadLine());
        if (indexSearch >= 0)
        {
            ShowSelectedData(indexSearch);
        }
        else
        {
            Console.WriteLine("Data Tidak Ditemukan");
        }

    }

    public void UpdateData(int index)
    {
        try
        {
            ShowSelectedData(index);
            Console.Write("Input First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input Password: ");
            String password = Console.ReadLine();
            String fullName = $"{firstName} {lastName}";
            String username = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            peopleDatabase[index].Name = fullName;
            peopleDatabase[index].Username = username;
            peopleDatabase[index].Password = password;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error Messages {e.Message}");
        }

        Console.WriteLine();
        Console.WriteLine($"Update Data dengan ID {peopleDatabase[index].Id} Berhasil");

    }

    private void ShowSelectedData(int index)
    {
        Console.WriteLine();
        Console.WriteLine($"{null,3} {peopleDatabase[index].Id} {null,5} {null,10}  {peopleDatabase[index].Name} {null,10} {null,5} {peopleDatabase[index].Password} {null,5} {null,8} ________ {null,5} ");
        Console.WriteLine();
    }



    private void DeleteDataFromDatabasePeople(int i)
    {
        peopleDatabase.RemoveAt(i);

    }



    private int findIndex(string id)
    {
        int respond = -1;
        for (int i = 0; i < peopleDatabase.Count; i++)
        {
            if (peopleDatabase[i].Id.Equals(Convert.ToInt32(id)))
            {
                respond = i;
            }
        }
        return respond;
    }

    private int findIndexSearch(string val)
    {
        int respond = -1;
        for (int i = 0; i < peopleDatabase.Count; i++)
        {
            try
            {
                if (peopleDatabase[i].Id.Equals(Convert.ToInt32(val)))
                {
                    respond = i;
                }
            }
            catch (FormatException e)
            {
                if (peopleDatabase[i].Name.Contains(val))
                {
                    respond = i;
                }
                else if (peopleDatabase[i].Username.Contains(val))
                {
                    respond = i;
                }
            }

        }
        return respond;
    }


    public void ShowData(List<People> personList)
    {
        Console.WriteLine($"{null,3} ID {null,5} {null,10}  Name {null,10} {null,5} Username {null,5} {null,8} Password {null,5} ");
        //Console.WriteLine($"{null,3} __ {null,5} {null,10}  ____ {null,10} {null,5} ________ {null,5} {null,8} ________ {null,5} ");
        Console.WriteLine();

        foreach (People person in peopleDatabase)
        {
            Console.WriteLine($"{null,3} {person.Id} {null,5} {null,10}  {person.Name} {null,10} {null,5} {person.Password} {null,5} {null,8} ________ {null,5} ");

        }
        Console.WriteLine();
    }



    public void SearchData(List<People> personList, String batas)
    {
        String[] menu = new string[2] { "ID", "Name" };

        for (int i = 0; i < menu.Length; i++)
        {
            Console.Write($"{i + 1,38}. {menu[i]}");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(batas);
        Console.WriteLine();
        Console.Write("Masukkan pilihan: ");
        int index = Convert.ToInt32(Console.ReadLine());
        switch (index)
        {
            case 1:
                {
                    Console.Write("Input Search ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(batas);
                    Console.WriteLine($"{null,3} ID {null,5} {null,10}  Name {null,10} {null,5} Username {null,5} {null,8} Password {null,5}");
                    Console.WriteLine();
                    Console.WriteLine(personList.Find(x => x.Id.Equals(id)));
                    Console.WriteLine();
                    Console.WriteLine(batas);
                    break;
                }
            case 2:
                {
                    Console.Write("Input Search Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(batas);
                    Console.WriteLine($"{null,3} ID {null,5} {null,10}  Name {null,10} {null,5} Username {null,5} {null,8} Password {null,5} ");
                    Console.WriteLine(personList.Find(x => x.Name.ToLower().Contains(name.ToLower())));
                    Console.WriteLine();
                    Console.WriteLine(batas);
                    break;
                }
            default:
                break;
        }
    }

    public void LoginPage(List<People> personList)
    {
        Console.WriteLine("Coming Soon");
    }
}
