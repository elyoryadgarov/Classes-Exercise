namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Year = 2005;
            car.Model = "Jetta";
            
            Console.WriteLine(car.Make + " \n" + car.Year + " \n"+car.Model);
            
            Car Toyota = new Car()
            {
                Make = "Toyota", 
                Year = 2018, 
                Model = "Highlander"
            };
            Console.WriteLine(Toyota.Make +  " \n" + Toyota.Year + " \n"+Toyota.Model);
            
        }
    }
}
