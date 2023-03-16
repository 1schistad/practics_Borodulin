class SmsMessage
{
    private string MessageText;
    private int MaxLength;
    private double StartPrice;
    private double Price4Symbol;

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

    public int GetMaxLength
    {
        get
        {
            return MaxLength;
        }
        private set
        {
            MaxLength = value;
        }
    }

    public double GetStartPrice
    {
        get
        {
            return StartPrice;
        }
        private set
        {
            StartPrice = value;
        }
    }
    public double GetPrice4Symbol
    {
        get
        {
            return Price4Symbol;
        }
        private set
        {
            Price4Symbol = value;
        }
    }
    private double Price {
        get
        {
            return CalculatePrice(StartPrice, Price4Symbol);
        }
    }

    public SmsMessage(string messageText, int maxlength, double startprice, double price4symbol)
    {
        MessageText = messageText;
        MaxLength = maxlength;
        StartPrice = startprice;
        Price4Symbol = price4symbol;
    }

    private string NormalizeMessageText(string Message)
    {
        if (Message.Length > 250)
        {
            return Message.Substring(0, Message.Length - 250);
        }
        return Message;
    }

    public void SendMessage()
    {
        Console.WriteLine($"Вы отправили сообщение длиной {MessageText.Length} символов и стоимостью {Price} руб.");
    }

    public double CalculatePrice(double startprice, double price4symbol)
    {
        if (MessageText.Length <= 65)
        {
            return StartPrice;

        }
        else
        {
            int maxlength = MessageText.Length - 65;
            return startprice + maxlength * price4symbol;
        }
    }

    public override string ToString()
    {
        return $"Сообщение: {MessageText}";
    }

    public static void Main(string[] args)
    {
        SmsMessage message = new SmsMessage("Исследование характеристик Нейтрали и её значимости Исследование характеристик Нейтрали и её значимости", 100, 2, 0.9);
        message.SendMessage();
        Console.WriteLine(message);
    }
}
