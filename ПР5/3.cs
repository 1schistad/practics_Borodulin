interface IFilter
{
    string Execute(string textLine);
}
class DigitFilter : IFilter
{
    public string Execute(string textline)
    {
        string stroka = "";
        char[] symbols = { '!', '?', ' ', ';', '-', '"', '(', ')', '.', ',', ':'};
        for (int i = 0; i < textline.Length; i++)
        {
            if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
            {
                stroka += textline[i];
            }
        }
        return stroka;
    }
}
class LetterFilter : IFilter
{
    public string Execute(string textline)
    {
        string stroka = "";
        for (int i = 0; i < textline.Length; i++)
        {
            if (char.IsDigit(textline[i]))
            {
                stroka += textline[i];
            }
        }
        return stroka;
    }
}
internal class zadacha3
{
    static void Main(string[] args)
    {
        DigitFilter Letters = new DigitFilter();
        Console.WriteLine(Letters.Execute("Номера автомобиля: 2МММ22"));
        LetterFilter Digits = new LetterFilter();
        Console.WriteLine(Digits.Execute("Номера автомобиля: 2МММ22"));
        Console.ReadKey(true);
    }
}