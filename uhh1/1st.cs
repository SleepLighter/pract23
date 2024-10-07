namespace uhh1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double three = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            double four = Convert.ToInt32(Console.ReadLine());
            double MidArif = (one + two + three + four) / 4;
            Console.WriteLine(MidArif);
        }
    }
}
namespace _3rd
{
    internal class Program
    {
        static void Task1();
        {
           
        }

    static void Main(string[] args)
    {
        Console.WriteLine("акое задание хоите увидеть:");
        Console.WriteLine("1");
        string choisetask = Console.ReadLine();
        if (choisetask == 1)
        {
            Task1();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("Вам необходимо ввести первое число, затем знак действия(+,-,*,/), которое хотите совершить и второе число.");

                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else if (oper == '%')
                {
                    total = a % b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
            }
        }
    }
}