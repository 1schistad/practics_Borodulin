class Games
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public Games(string name, string genre, string description)
    {
        Name = name;
        Genre = genre;
        Description = description;
    }
}
class Dota2 : Games
{
    public Dota2(string name, string genre, string description) : base(name, genre, description)
    {
        Genre = genre;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Games AtomicHeart = new Games("Atomic Heart", "Шутер от первого лица", "Игра отличная, но местами было душно");
        Console.WriteLine(AtomicHeart.Name);
        Console.WriteLine(AtomicHeart.Genre);
        Console.WriteLine(AtomicHeart.Description);
        Dota2 dota = new Dota2("Dota 2", "MOBA", "Отличная игра, узнал много нового про себя и своих родных, всем советую");
        Console.ReadKey(true);
    }
}