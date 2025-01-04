namespace Lesson 2.1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce your name: ");
            string name = Console.ReadLine();
            double age, height;
            Console.WriteLine("Introduce your age: ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce your height: ");
            height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine($"Hi, {name}! {"\n"} {"\t"} Your age: {age} years. {"\n"} {"\t"} {"\t"} Your height: {height} м.");
            Console.ReadKey();
        }
    }
}
