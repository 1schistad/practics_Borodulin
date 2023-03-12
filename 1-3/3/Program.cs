class CesarShifr
{
    static void Main(String[] args)
    {
        Console.WriteLine("Введите текст, который нужно зашифровать");
        string text = Console.ReadLine();
        Console.WriteLine("Введите ключ");
        int key = Convert.ToInt32(Console.ReadLine());
        string ztext = z(text, key);
        Console.WriteLine("Зашифрованный текст: " + ztext);
        Console.WriteLine("Расшифрованый текст: " + rtext(ztext, key));
        Console.ReadLine();

    }

    static string z(string text, int key)
    {
        string z = "";
        for (int i = 0; i < text.Length; i++)
        {
            z += (char)(text[i] + key);
        }
        return z;
    }

    static string rtext(string text, int key)
    {
        string r = "";
        for (int i = 0; i < text.Length; i++)
        {
            r += (char)(text[i] - key);
        }
        return r;
    }
}