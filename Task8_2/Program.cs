using System.Xml.Serialization;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {
                Console.WriteLine("Введите возраст");
                int a = Convert.ToInt32(Console.ReadLine());
                ValidateAge(a);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Слишком большой возраст");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Возраст не может быть отрицательным");
            }            

            static void ValidateAge(int a)
            {
                if (a < 0)
                {
                    throw new ArgumentException("Возраст не может быть отрицательным");
                }
                if (a > 150)
                {
                    throw new ArgumentOutOfRangeException("Слишком большой возраст");
                }                
            }
            Console.ReadLine();
        }
    }
}


