//A(m*n) * B(n*k) = С(m*k)
int m,n,n1,k;
m = 6; // строки array1
n = 4; //столбцы array1

k = 4; // столбцы array2
n1 = 4; // строки array2
int[,] array1 = new int[m,n];
int[,] array2 = new int[n,k];
int[,] array3 = new int[m,k];



for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array1[i, j] = 1;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        array2[i, j] = 2;
    }
}




if (n != n1)
{
    Console.WriteLine("всё очень плохо");
}
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
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        Console.Write(array3[i,j]);
    }
    Console.WriteLine();
}