using System.Xml.Linq;

class Spell
{
    public int Mana { get; private set; }
    private string Effect { get; set; }

    public string Name { get; private set; }
    public Spell(int mana, string effect, string name)
    {
        Mana = mana;
        Effect = effect;
        Name = name;
    }

    public void Use()
    {
        Console.WriteLine(Effect);
    }
}

class Magician
{
    public string Name { get; private set; }
    public int Mana { get; private set; }

    public Magician (string name, int mana)
    {
        Name = name;
        Mana = mana;
    }

    public void CastSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
           
            Console.WriteLine("{0} колдует!", Name);
            spell.Use();
            Mana -= spell.Mana;
        }
        else
        {
            int mana = Mana;
            Console.WriteLine("Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", spell.Name, mana);
        }
    }
}

class zadacha1{
    static void Main()
    {
        Spell alohomora = new Spell(60, "Замок открывается!", "Алохомора");
        Spell vingardiumLeviosa = new Spell(60, "Предмет поднимается в воздух!", "Вингардиум Левиоса");

        Magician garryPotter = new Magician("Гарри Поттер", 100);

        garryPotter.CastSpell(alohomora);
        garryPotter.CastSpell(vingardiumLeviosa);

        Console.ReadKey();
    }
}