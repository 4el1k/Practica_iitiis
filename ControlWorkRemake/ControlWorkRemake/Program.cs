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
            Matrix mm = new Matrix(m1);
            Matrix mm1 = new Matrix(m2);
            Matrix mm2 = mm*mm1;
            Matrix mmm = new Matrix(m3);
            Console.WriteLine(mmm.IsSymmetric);





        }
    }
}