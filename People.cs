using System;
using System.Collections.Generic;
using System.Linq;

public class People : IEquatable<People>
{
    public string Name { get; set; }

    public string Username { get; set; }

    public int Id { get; set; }

    public String Password { get; set; }

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

    public void ShowData(List<People> personList)
    {
        Console.WriteLine($"{null,3} ID {null,5} {null,10}  Name {null,10} {null,5} Username {null,5} {null,8} Password {null,5} ");
        //Console.WriteLine($"{null,3} __ {null,5} {null,10}  ____ {null,10} {null,5} ________ {null,5} {null,8} ________ {null,5} ");
        Console.WriteLine();
        foreach (People person in personList)
        {
            Console.WriteLine($"{person}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void DeleteData(List<People> personList, String choice)
    {
        do
        {
            Console.Write("Input ID yang akan dihapus: ");
            int id = Convert.ToInt32(Console.ReadLine());
            personList.Remove(new People() { Id = id });
            Console.Clear();
            Console.WriteLine("produk berhasil dihapus");
            Console.WriteLine();
            Console.Write("Hapus Produk lagi? (Y/N)");
            choice = Console.ReadLine();
        } while (choice.ToUpper() == "Y");
    }
}
