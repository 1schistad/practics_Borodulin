using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace pr2
{
    class KvadrUrav
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;
        private double discr;

        private double getA()
        {
            return a;
        }

        private double getB()
        {
            return b;
        }

        private double getC()
        {
            return c;
        }
        public double getX1()
        {
            return x1;
        }
        public double getX2()
        {
            return x2;
        }

        public double getDiscr()
        {
            return discr;
        }

        private double Discriminant()
        {
            discr = (b * b) - 4 * a * c;
            return discr;
        }

        private void CalculateRoots()
        {
            this.discr = Discriminant();
            if (discr > 0)
            {
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("x1 = "+x1+", x2 = " +x2);
            }
            else if (discr == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x = " + x1);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
        }

        public void getRoots()
        {
            CalculateRoots();
        }

        public KvadrUrav(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("Первый коэффициент = " + a);
            Console.WriteLine("Второй коэффициент = " + b);
            Console.WriteLine("Третий коэффициент = " + c);
        }
    }

    internal class Korni
    {
        static void Main(string[] args)
        {
            KvadrUrav chisla = new KvadrUrav(1, 10, -39);
            chisla.getRoots();
            Console.ReadKey(true);
        }
    }
}
