namespace Transport
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Машина");
            ITransport car = new Car(220, 40);
            Console.WriteLine(car);
            car.SpeedDown(); //speed -5
            Console.WriteLine(car);
            car.SpeedUp(); //speed +5
            Console.WriteLine(car);
            Console.WriteLine();

            Console.WriteLine("Корабль");
            ITransport ship = new Ship(40, 30, "Москва", "Воронеж");
            Console.WriteLine(ship);
            ship.SpeedDown(); //speed +1
            Console.WriteLine(ship);
            ship.SpeedUp(); //speed -1
            Console.WriteLine(ship);
            Console.WriteLine();

            Console.WriteLine("Самолет");
            ITransport plane = new AirPlane(500, 240, "Самара", "Ульяновск  ");
            Console.WriteLine(plane);
            plane.SpeedDown(); //speed -20
            Console.WriteLine(plane);
            plane.SpeedUp(); //speed +20
            Console.WriteLine(plane);
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                ship.SpeedDown();
            }
        }
    }
}