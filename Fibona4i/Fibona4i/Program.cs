using System.Text;
using System.Threading.Tasks;

namespace Fibona4i
{
    public class Program
    {
        public static void Main()
        {
            int x = Fibonachi.FibonachiWithDynamics(8);
            int y = Fibonachi.FibonachiWithRecursion(8);
            Console.WriteLine($"{x}, {y}");
        }
    }
}