namespace ControlWorkRemake
{
    class Program
    {
        public static void Main()
        {

            int[,] m1 = new int[,]
            {
                {1,1,1 },
                {1,1,1 },
                {1,1,1 }
            };
            int[,] m2 = new int[,]
            {
                {1,1,1 },
                {1,1,1 },
                {1,1,1 }
            };
            int[,] m3 = new int[,]
            {
                {1,3,4 },
                {3,1,5 },
                {4,5,1 }
            };

            Console.WriteLine("конструктор 1");
            Matrix matrica1 = new Matrix();
            Console.WriteLine(matrica1);

            Console.WriteLine();

            Console.WriteLine("конструктор 2");
            Matrix matrica2 = new Matrix(6,6);
            Console.WriteLine(matrica2);

            Console.WriteLine("конструктор 3");

            string str = "C:\\Users\\salav\\source\\repos\\" +
                "Practica_iitiis\\ControlWorkRemake\\ControlWorkRemake\\filename.txt";
            Matrix matrica3 = new Matrix(str,3);
            Console.WriteLine(matrica3);
            

            Console.WriteLine("сложение");
            Matrix k1 = new Matrix(m3);
            Matrix k2 = new Matrix(m2);
            Matrix k3 = k1 + k2;
        }
    }
}