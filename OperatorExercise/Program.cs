namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        public static void Exercise2()
        {
            Console.Write("Enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void Exercise1()
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {difference}.");
            Console.WriteLine($"{a}*{b} is {product}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

        }
    }
}
