
namespace Greenie;

public class Challenge
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public Challenge() { }

    public Challenge(string title) : this()
    {
        Title = title;
    }

    public override string ToString()
    {
        return Title + " ";
    }

    public override bool Equals(object? obj)
    {
        return obj is Challenge challenge &&
               Title == challenge.Title;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title);
    }
}


