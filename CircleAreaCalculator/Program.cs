namespace CircleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the circle area calculator!");

            Console.Write("Enter the ray of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double area = pi * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");

            Console.ReadLine();
        }
    }
}