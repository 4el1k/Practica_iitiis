int n = 6;
int[,] arr1 = new int[n, n]; //массив который нужно повернуть
int[,] arr2 = new int[n, n]; //результат поворота

//заполнение массива arr1
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr1[i, j] = i;
    }
}
//массив заполнен

// main
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr2[j, i] = arr1[n - 1 - i, j];  //при повороте первая строчка с конца встает на место первого столбца
    }                                     //второая строчка с конца встает на место второго столбца и так далее
}
// main



//вывод первого и второго массива
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr1[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr2[i,j]);
    }
    Console.WriteLine();
}