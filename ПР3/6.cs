class MyRandomList
{
    private List<int> numbersList = new List<int>();
    Random rand = new Random();
    private int length
    {
        set
        {
            SetLength(value);
        }
    }
    public double Average
    {
        get
        {
            return CalculateAverage();
        }
    }
    public double Dispersia
    {
        get
        {
            return CalculateDispersia();
        }
    }
    public double Otklonenie
    {
        get
        {
            return CalculateOtklonenie();
        }
    }
    public double Mediana
    {
        get
        {
            return CalculateMediana();
        }
    }
    private void SetLength(int length)
    {
        length = numbersList.Count;
    }
    public void AddNumber()
    {
        numbersList.Add(rand.Next(201));
    }
    public void RemoveNumber(int number)
    {
        numbersList.Remove(number);
    }
    private double CalculateAverage()
    {
        int average = 0;
        foreach (int number in numbersList)
        {
            average += number;
        }
        return average / numbersList.Count;
    }
    private double CalculateDispersia()
    {
        double sum = 0;
        foreach (int number in numbersList)
        {
            sum += Math.Pow((number - Average), 2);
        }
        return Math.Round(sum / numbersList.Count, 2);
    }
    private double CalculateOtklonenie()
    {
        CalculateDispersia();
        return Math.Round(Math.Sqrt(Dispersia), 2);
    }
    private double CalculateMediana()
    {
        numbersList.Sort();
        if (numbersList.Count % 2 == 0)
        {
            return (numbersList[numbersList.Count / 2] + numbersList[numbersList.Count / 2 - 1]) / 2;
        }
        else
        {
            double mid = numbersList.Count / 2;
            mid = Math.Ceiling(mid);
            return numbersList[Convert.ToInt32(mid)];
        }
    }

    static void Main(string[] args)
    {
        MyRandomList numbers = new MyRandomList();
        for (int i = 0; i < 21; i++)
        {
            numbers.AddNumber();
        }
        Console.WriteLine("Дисперсия = " +numbers.Dispersia);
        Console.WriteLine("Отклонение = " + numbers.Otklonenie);
        Console.WriteLine("Медиана = " + numbers.Mediana);
        Console.ReadKey(true);
    }
}


