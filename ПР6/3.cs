class Human
{
    public string Name{get;set;}
    public int Age{get;set;}
    public char Gender{get;set;}
    public Human(string name, int age, char gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}
class Worker : Human
{
    public string Position{get;set;}
    public Worker(string name, int age, char gender, string position) : base(name, age, gender)
    {
        Position = position;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Human Morgenshtern = new Human("Алла Пугачёва", 73, 'Ж');
        Console.WriteLine(Morgenshtern.Name);
        Worker Alla = new Worker("Алла Пугачёва", 73, 'Ж', "Певица");
        Console.WriteLine(Alla.Position);
        Console.ReadKey(true);
    }
}
