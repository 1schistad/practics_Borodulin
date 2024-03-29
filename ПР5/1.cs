﻿interface IAnimal
{
    void Voice();
}
class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав!");
    }
}
class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу!");
    }
}
class Owl : IAnimal
{
    private int GetCurrentTime()
    {
        return Convert.ToInt32(File.ReadAllText("current_time.txt"));
    }
    public void Voice()
    {
        int currentTime = GetCurrentTime();
        if ((currentTime >= 8) && (currentTime <= 21))
        {
            Console.WriteLine("Тисе, я спю!");
        }
        else
        {
            Console.WriteLine("Ух! Ух! Ух!");
        }
    }
}

class Frog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ква-ква!");
    }
}

class Cow : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Му-му");
    }
}

internal class Program
{
    static void PetAnimal(IAnimal animal)
    {
        Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
        animal.Voice();
    }
    static void Main(string[] args)
    {
        List<IAnimal> myAnimals = new List<IAnimal>();
        myAnimals.Add(new Dog());
        myAnimals.Add(new Cat());
        myAnimals.Add(new Owl());
        myAnimals.Add(new Frog());
        myAnimals.Add(new Cow());
        foreach (IAnimal animal in myAnimals)
        {
            PetAnimal(animal);
        }
        Console.ReadKey(true);
    }
}