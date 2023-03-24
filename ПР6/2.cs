class TransportVehicle
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public TransportVehicle(string name, int speed)
    {
        Name = name;
        MaxSpeed = speed;
    }
}
class PolitehMachine : TransportVehicle
{
    public void TurnOnInstasamka()
    {
        Console.WriteLine("Кто это включил? Не давайте ему больше за плейлистом следить");
    }
    public PolitehMachine(string name, int speed) : base(name, speed)
    {
    }
}
class Plane : TransportVehicle
{
    public void PollinateField()
    {
        Console.WriteLine("Поле опылили");
    }
    public Plane(string name, int speed) : base(name, speed)
    {
    }
}
class ConcreteMixer : TransportVehicle
{
    public void ConcreteMix()
    {
        Console.WriteLine("Бетон замешали");
    }
    public ConcreteMixer(string name, int speed) : base(name, speed)
    {
    }
}
internal class zadacha2
{
    static void Main(string[] args)
    {
        TransportVehicle Car = new TransportVehicle("Матиз", 450);
        PolitehMachine Politeh = new PolitehMachine("Машина политеха", 150);
        Politeh.TurnOnInstasamka();
        Plane Aerobus = new Plane("Аэробус", 1000);
        Aerobus.PollinateField();
        ConcreteMixer betonomeshalka = new ConcreteMixer("Бетономешалка", 250);
        betonomeshalka.ConcreteMix();
        Console.ReadKey(true);
    }
}