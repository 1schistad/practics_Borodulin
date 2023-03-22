interface IHello
{
    void SayHello();
}
class Russian : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Привет");
    }
}
class English : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}
class Spain : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hola");
    }
}
class Deutsch : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hallo");
    }
}
class Tajik : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Салом");
    }
}
internal class zadacha2
{
    static void Main(string[] args)
    {
        List<IHello> Hello = new List<IHello>();
        Hello.Add(new Russian());
        Hello.Add(new English());
        Hello.Add(new Spain());
        Hello.Add(new Deutsch());
        Hello.Add(new Tajik());
        foreach (IHello hello in Hello)
        {
            hello.SayHello();
        }
        Console.ReadKey(true);
    }
}