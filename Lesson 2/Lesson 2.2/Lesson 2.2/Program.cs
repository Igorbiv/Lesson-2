namespace Lesson_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, doubleValue;
            Console.WriteLine("Insert number 1: ");
            firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert number  2: ");
            doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sum of numbers: " + (firstValue + doubleValue));
            Console.WriteLine("the difference of numbers: " + (firstValue - doubleValue));
            Console.WriteLine("the multiplication of numbers: " + (firstValue * doubleValue));
            Console.WriteLine("the dividing of numbers: " + (firstValue / doubleValue));
            Console.ReadKey();
        }
    }
}
