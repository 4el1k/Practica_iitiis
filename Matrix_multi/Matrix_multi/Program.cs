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
//память
int m,n,n1,k;
m = 4; // строки array1
n = 4; //столбцы array1
k = 4; // столбцы array2
n1 = 4; // строки array2
int[,] array1 = new int[m,n];
int[,] array2 = new int[n,k];
int[,] array3;
//память

//заполнение первого и второго массива
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
//заполнение первого и второго массива

//array3 = Multiply(array1,array2);


//main
int nearestWhole2=1;
int pow2nearestWhole = 0;

int twoPowK = 1;

int inputPow = 135;
int currentPow = 1;
int pow=1;
k = 0;
int z = 0;
int[,] promezhutok = new int[n, n];
while (nearestWhole2 < inputPow)
{
    nearestWhole2 *= 2; //ближайшее число, которео является степнью 2
    pow2nearestWhole += 1; //степень этого числа
}
int z1 = 0,z2=1;
//разница
while (z2<inputPow - nearestWhole2)
{
    z2 *= 2; 
    z1 += 1; 
}
int[][,] massive_for_power_matrix = new int[z1][,];
massive_for_power_matrix[0] = array1;
while (true)
{
    
    if (pow*2<=inputPow) //после первого false, больше никогда не сработает
    {
        promezhutok = Multiply(promezhutok, promezhutok);
        //promezhutok = Multiply(promezhutok, promezhutok); можно так записать

        pow *= 2; //pow - это число, в степень которого возводим матрицу сейчас. pow - степень двойки
        k++; //k выступает в роли индекса.
        if (k < z1)
        {
            massive_for_power_matrix[k] = promezhutok; //на k индексе хранится матрица A^(2k);
        }
        twoPowK *= k; //нужно чтобы не юзать Math.Pow
        currentPow = k; //в этой переменной хранится индекс матрицы, возведенную в максимальную степень
    }
    


    else
    {
        twoPowK /= k;
        k--;
        // (pow * Math.Pow(2,k)<=inputPow)
        if (k!=0) //тело этого ифа будет выполняться, пока можно как-то оптимизровать 
        {
            if (pow + k <= inputPow)
            {
                promezhutok = Multiply(massive_for_power_matrix[k], promezhutok);
                pow += k;

            }
        }
        else
        {
            if (pow+1<=inputPow)
            {
                promezhutok = Multiply(promezhutok, array1);
            }
            else
            {
                break;
            }

        }
    }

}
Console.WriteLine(promezhutok);





//main