//A(m*n) * B(n*k) = С(m*k)
//функция перемножения двух матриц
int[,] Multiply(int[,] array1, int[,] array2)
{
    int m = array1.GetLength(0); //строки
    int n = array1.GetLength(1); //столбцы

    int n1 = array2.GetLength(0); //строки
    int k = array2.GetLength(1);  //столбцы
    if (n != n1)
    {
        Console.WriteLine("всё очень плохо");
        return new int[0,0];
    }
    int[,] array3 = new int[m, k];
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int r = 0; r < k; r++)
        {
            sum = 0;

            for (int j = 0; j < n; j++)
            {
                sum += array1[i, j] * array2[j, r];
            }
            array3[i, r] = sum;
        }
    }
    return array3;
}
//функция перемножения двух матриц
int n = 6;
int[,] array = new int[n, n];

//массив заполняется
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = 2;
    }
}
//массив заполняется
int inputInt = 10;
int bliz_stepen_2=1,z=0;
int pow = 1;
int[,] ans = new int[n, n];
ans = array;
while (bliz_stepen_2<inputInt)
{
    bliz_stepen_2 *= 2;
}
bliz_stepen_2 /= 2;
int bliz_stepen_2_ = 1;
while (bliz_stepen_2_<inputInt-bliz_stepen_2)
{
    bliz_stepen_2_ *= 2;
    z++;
}
int r = z - 1;
int k = 0;
int[][,] massive_for_pow_matrix = new int[z][,];
massive_for_pow_matrix[0] = array;
while (true)
{
    if (pow * 2 <= inputInt)
    {
        ans = Multiply(ans, ans);
        pow *= 2;
        k++;
        
        if (k < z)
        {
            massive_for_pow_matrix[k] = ans;
        }

    }
    else
    {
        if (pow==inputInt)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ans[i,j]);
                }
                Console.WriteLine();
            }
            break;
        }
        if (inputInt - pow != 1)
        {
            if (pow + z <= inputInt)
            {
                ans = Multiply(ans, massive_for_pow_matrix[z - 1]);
                pow += z;
            }
            else
            {
                z--;
            }
        }
        
        else
        {
            ans = Multiply(ans, array);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ans[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            break;
        }
    }
}