namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {
                Console.WriteLine("Введите два целых числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции. Например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                int с = Convert.ToInt32(Console.ReadLine());

                switch (с)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;

                }



            }
            catch (FormatException)
            {
                Console.WriteLine("Нечисловой ввод");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
            Console.ReadLine();

        }
    }
}
