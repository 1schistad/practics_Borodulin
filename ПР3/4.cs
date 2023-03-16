


class MyIntList
{
    private List<int> numbersList = new List<int>();
    public int Summa
    {
        get
        {
            return CalculateSum();
        }
    }
    public double Average
    {
        get
        {
            return CalculateAverage();
        }
    }
    public void AddNumber(int number)
    {
        numbersList.Add(number);
    }
    public void RemoveNumber(int number)
    {
        numbersList.Remove(number);
    }
    private int CalculateSum()
    {
        int summa = 0;
        foreach (int number in numbersList)
        {
            summa += number;
        }
        return summa;
    }
    private double CalculateAverage()
    {
        return Summa / (double)numbersList.Count;
    }

    static void Main(string[] args)
    {
        MyIntList numbers = new MyIntList();
        numbers.AddNumber(14);
        numbers.AddNumber(25);
        numbers.AddNumber(23);
        numbers.AddNumber(6);
        numbers.AddNumber(3);
        Console.WriteLine(numbers.Average);
        Console.WriteLine(numbers.Summa);
        Console.ReadKey(true);
    }
}
