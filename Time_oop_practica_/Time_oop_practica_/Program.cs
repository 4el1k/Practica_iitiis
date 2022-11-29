
namespace Time_oop_practica_
{
    public class Program
    {
      
        static void Main(String[] args)
        {
            Time time1 = new Time(54, 54, 76);
            Time time2 = new Time(4, 6, 8);
            Time time3 = new Time(0, 0, 86400);

            time1.Second = 100;

            time2.Minute = 100;
            Console.WriteLine(time2);
            
        }
    }
}