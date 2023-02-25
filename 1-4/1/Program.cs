using System.Runtime.Intrinsics.X86;
Car Bugatti = new Car(500);
Console.WriteLine("Скорость Bugatti Chiron Super Sport = " + Bugatti.maxSpeed + " км/ч");
Car Koenigsegg = new Car(499);
Console.WriteLine("Скорость Koenigsegg Jesko Absolut = " + Koenigsegg.maxSpeed + " км/ч");
Car SSC = new Car(460);
Console.WriteLine("Скорость SSC Tuatara = " + SSC.maxSpeed + " км/ч");
Car Hennessey = new Car(450);
Console.WriteLine("Скорость Hennessey Venom F5 = " + Hennessey.maxSpeed + " км/ч");



if (Bugatti.maxSpeed > Koenigsegg.maxSpeed)
{
    Console.WriteLine("Bugatti - 1 место");
}

if (Koenigsegg.maxSpeed > SSC.maxSpeed)
{
    Console.WriteLine("Koenigsegg - 2 место");
}

if (SSC.maxSpeed > Hennessey.maxSpeed)
{
    Console.WriteLine("SSC - 3 место" + "\n" + "Hennessey - 4 место");
}


class Car
{
    public double maxSpeed;

    public Car(double maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }
}

