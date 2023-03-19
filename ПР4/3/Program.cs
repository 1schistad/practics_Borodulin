class Ork
{
    public int Gold { get; private set; }

    private static int CountGold;

    public static int GoldAll { get; private set; }

    public Ork()
    {
        CountGold++;
        GoldAll += 2;
        if (CountGold > 5)
        {
            Gold += 2;
            GoldAll -= 2;
        }
    }

}

class zadacha3
{
    static void Main(string[] args)
    {
        Ork orc_1 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 1-ого орка = " + Ork.GoldAll);
        Ork orc_2 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 2-ого орка = " + Ork.GoldAll);
        Ork orc_3 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 3-го орка = " + Ork.GoldAll);
        Ork orc_4 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 4-ого орка = " + Ork.GoldAll);
        Ork orc_5 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 5-ого орка = " + Ork.GoldAll);
        Ork orc_6 = new Ork();
        Console.WriteLine("Кол-во переносимого золота у 6-ого орка = " + orc_6.Gold);
        Console.ReadKey(true);
    }
}