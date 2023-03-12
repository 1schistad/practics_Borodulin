ZadanieDva n = new ZadanieDva();
n.writenumber();

while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (n.setN(number))
    {
        n.writenumber();
    }
    else
    {
        Console.WriteLine("Введено неверное число");
        break;
    }
}


class ZadanieDva
{
    private int n = 0;

    public int getN()
    {
        return n;
    }

    public void repeat()
    {
        n = 0;
    }

    public bool setN(int n)
    {
        if(this.n+1 == n) {
            this.n = n;
            return true;
        } else
        {
            repeat();
            return false;
        }
    }


    public void writenumber()
    {
        Console.WriteLine("Введите число " + (this.n+1));
    }

}