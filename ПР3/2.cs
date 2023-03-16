class SmsMessage
{
    private string MessageText;

    public string GetMessageText
    {
        get
        {
            return MessageText;
        }
        private set
        {
            MessageText = NormalizeMessageText(value);
        }
    }
    private double Price { get; set; }

    public SmsMessage(string messageText)
    {
        MessageText = messageText;
        Price = 0;
    }

    private string NormalizeMessageText(string Message)
    {
        if (Message.Length > 250)
        {
            return Message.Substring(0, Message.Length - 250);
        }
        return Message;
    }

    public void CalculatePrice()
    {
        if (MessageText.Length <= 65)
        {
            Price = 150;
            
        }
        else 
        {
            Price = 150 + (MessageText.Length - 65) * 50;
        }
    }

    public override string ToString()
    {
        return $"Сообщение: {MessageText}, Цена:{Price}";
    }

    public static void Main(string[] args)
    {
        SmsMessage message = new SmsMessage("Исследование характеристик Нейтрали и её значимости Исследование характеристик Нейтрали и её значимости");
        message.CalculatePrice();
        Console.WriteLine(message);
    }
}