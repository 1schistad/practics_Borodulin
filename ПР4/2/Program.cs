using System.Collections.Generic;

class Posilka
{
    public string Description { get; private set; }
    public int Weight { get; private set; }

    public Posilka(string description, int weight)
    {
        Description = description;
        Weight = weight;
    }
}

class SendingService
{
    public int WeightLimit { get; private set; }

    private const int Limit = 20;

    public void SendPosilka(Posilka posilka)
    {
        WeightLimit += posilka.Weight;
        if (WeightLimit >= Limit)
        {
            Console.WriteLine("Вес посылок превысил лимит, отправка отменена");
        }
        else
        {
            Console.WriteLine("Посылка {0} весом {1} кг успешно отправлена", posilka.Description, posilka.Weight);
        }
    }
}

class zadacha2
{
    static void Main()
    {
        Posilka posilkaName = new Posilka("'Телефон Ultra Super Hyper Xiamo Poko Pro 3'", 5);
        SendingService sendingService = new SendingService();
        sendingService.SendPosilka(posilkaName);
        Console.ReadKey();
    }
}