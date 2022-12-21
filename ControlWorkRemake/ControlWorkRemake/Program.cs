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
            Console.WriteLine(k3);

            Console.WriteLine("умножение");
            Console.WriteLine(k1*k3);


            string filename1 = "C:\\Users\\salav\\source\\repos\\" +
                "Practica_iitiis\\ControlWorkRemake\\ControlWorkRemake\\filename1.txt";
            Console.WriteLine("запись файла");
            k3.InstallMatrix(filename1);
            Matrix k6 = new Matrix(filename1, k3.QuantityColumns);
            Console.WriteLine(k6);

            int[,] m6 = new int[,]
            {
                {1,1,1 },
                {-6,1,7 },
                {1,2,1 }
            };
            Matrix l = new Matrix(m6);
            Console.WriteLine("транспонирование");

            Console.WriteLine("просто матрица");
            Console.WriteLine(l);
            Console.WriteLine();
            Console.WriteLine("транспонированная");
            Console.WriteLine(Matrix.Transponir(l));
        }
    }
}