namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            // Set values in the properties for the object
            // Print the values of each property to the Console
            var car1 = new Car()
            {
                Make = "Corvette",
                Model = "Stingray",
                Year = 69,
            };
            Console.WriteLine($"{car1.Make}\n{car1.Model}\n{car1.Year}");
        }
    }
}
