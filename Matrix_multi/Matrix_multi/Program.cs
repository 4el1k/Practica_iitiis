//A(m*n) * B(n*k) = С(m*k)
//функция перемножения двух матриц
ulong[,] Multiply(ulong[,] array1, ulong[,] array2)
{
    int m = array1.GetLength(0); //строки
    int n = array1.GetLength(1); //столбцы

    int n1 = array2.GetLength(0); //строки
    int k = array2.GetLength(1);  //столбцы
    if (n != n1)
    {
        Console.WriteLine("всё очень плохо");
        return new ulong[0,0];
    }
    ulong[,] array3 = new ulong[m, k];
    ulong sum = 0;
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

//создание массива для возведнения в степень
int n = 6;
ulong[,] array = new ulong[n, n];

//массив заполняется
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = 2;
    }
}
//массив заполняется

//инициализация переменных и массивов

int inputInt = 24; //степень, в которую нужно возвести матрицу (работает до 24)
int bliz_stepen_2 = 1; //мусор, нужен только для z
int z=0; //для того чтобы знать степени, для возведения матрицы в них, чтобы потом их (матрицы) сохранить
int pow = 1; //в какую степень сейчас возведена матрица
ulong[,] ans = new ulong[n, n]; //это матрица - ответ
ans = array;
inputInt = 20;//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//ищем ближайшее число для степени в которую нужно возвести матрицу, являющееся степенью двойки
while (bliz_stepen_2*2<=inputInt) 
{
    bliz_stepen_2 *= 2;
}
Console.WriteLine(bliz_stepen_2);
//закончили искать

//теперь нам нужно найти ближайшее число являющееся степенью двойки
//для разницы (ближ.цел.числ.явл.степ.2 для степени, в которую нужно возвести число) и (самим числом) 
//и мы должны узнать, степень этого числа
int bliz_stepen_2_ = 1;

while (bliz_stepen_2_*2<=inputInt-bliz_stepen_2)
{
    bliz_stepen_2_ *= 2;
    z++;
}
Console.WriteLine($"{z} {bliz_stepen_2_}");
//закончили искать
//----
int z1 = 1;
int k = 1; 
ulong[][,] massive_for_pow_matrix = new ulong[z+1][,];
massive_for_pow_matrix[0] = array;
if (z>0)
{
    massive_for_pow_matrix[1] = array;
    z1 = z;
}
bool flag = true;
//инициализация переменных и массивов
while (flag)
{
    if (pow * 2 <= inputInt)
    {
        ans = Multiply(ans, ans);
        pow *= 2;

        k++; //изначально еденичка
        if (k <= z)
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
                    Console.Write($"{ans[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            flag = false;
        }
        
        
        if (pow + z1 <= inputInt)
        {
            ans = Multiply(ans, massive_for_pow_matrix[z1-1]);
            pow += z1;
        }

        else
        {
            z1--;
        }


        /*
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
        */
    }
}
    
