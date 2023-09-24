namespace RectangleAreaCalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rectangle Area Calculator!");

            Console.Write("Enter the lenght of the rectangle: ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = lenght * width;

            Console.WriteLine($"The area of the rectangle is {area}");

            Console.ReadLine();
        }
    }
}