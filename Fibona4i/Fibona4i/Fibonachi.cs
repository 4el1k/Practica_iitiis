using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fibona4i
{
    internal class Fibonachi
    {
        static int FibonachiRecursion(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;
            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }
        
        public static int FibonachiWithRecursion(int n)
        {
            return FibonachiRecursion(n);
        }


        static int FibonachiDynamics(int n, int x, int y)
        {
            for (int i = 3; i <= n; i++)
            {
                int k = x + y;
                x = y;
                y = k;
            }
            return y;
        }

        public static int FibonachiWithDynamics(int n)
        {
            return FibonachiDynamics(n, 1, 1);
        
    }
}
