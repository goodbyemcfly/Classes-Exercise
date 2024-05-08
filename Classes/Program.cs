namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Prius";
            myCar.Year = 2014;

            Console.WriteLine($"My cars model is: {myCar.Model}");
            Console.WriteLine($"My cars make is: {myCar.Make}");
            Console.WriteLine($"My cars year is: {myCar.Year}");
        }
    }
}
