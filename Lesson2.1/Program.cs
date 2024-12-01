namespace Lesson2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            double age, height;
            Console.WriteLine("Введите возраст: ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в сантиметрах: ");
            height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine($"Привет, {name}! {"\n"} {"\t"} Ваш возраст: {age} лет. {"\n"} {"\t"} {"\t"} Ваш рост: {height} м.");
            Console.ReadKey();
        }
    }
}
