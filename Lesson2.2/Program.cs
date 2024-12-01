namespace Lesson2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, doubleValue;
            Console.WriteLine("Введите число 1: ");
            firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма чисел: " + (firstValue + doubleValue));
            Console.WriteLine("Разность чисел: " + (firstValue - doubleValue));
            Console.WriteLine("Произведение чисел: " + (firstValue * doubleValue));
            Console.WriteLine("Частное чисел: " + (firstValue / doubleValue));
            Console.ReadKey();
        }
    }
}
