interface IShare
{
    void Draw(int size);
}

class HorizontalLine : IShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
    }
}
class VerticalLine : IShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("-");
        }
    }
}
class Square : IShare
{
    public void Draw(int size)
    {
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

    }
}
internal class zadacha4
{
    static void Main(string[] args)
    {
        List<IShare> Figures = new List<IShare>();
        Figures.Add(new HorizontalLine());
        
        Figures.Add(new VerticalLine());
        Figures.Add(new Square());
        foreach (IShare figure in Figures)
        {
            figure.Draw(10);
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}