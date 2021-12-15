using System;

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

    public int GetId()
    {
        return Id;
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
}
