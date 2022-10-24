//сложность ал-ма O( log2(n) + log2(n-log(n-log(n)))) = O( log2(n^2-n*log(n)) )
//A(m*n) * B(n*k) = С(m*k)
//функция перемножения двух матриц
double[,] Multiply(double[,] array1, double[,] array2)
{
    int m = array1.GetLength(0); //строки
    int n = array1.GetLength(1); //столбцы

    int n1 = array2.GetLength(0); //строки
    int k = array2.GetLength(1);  //столбцы
    if (n != n1)
    {
        Console.WriteLine("всё очень плохо");
        return new double[0,0];
    }
    double[,] array3 = new double[m, k];
    double sum = 0;
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
double[,] array = new double[n, n];

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
double[,] ans = new double[n, n]; //это матрица - ответ
ans = array;
//ищем ближайшее целое число снизу, явл. степ. двойки
while (bliz_stepen_2*2<=inputInt) 
{
    bliz_stepen_2 *= 2;
}
Console.WriteLine(bliz_stepen_2);
//закончили искать

//теперь нам нужно найти ближайшее число являющееся степенью двойки для разницы 
//(ближ.цел.числ.явл.степ.2 для степени, в которую нужно возвести число) и (самим числом) 
//и мы должны узнать, степень этого числа
int bliz_stepen_2_ = 1;

while (bliz_stepen_2_*2<=inputInt-bliz_stepen_2)
{
    bliz_stepen_2_ *= 2;
    z++;
}
//закончили искать
//далее память будет выделена для сохранения матриц в каких либо степенях
int k = 1; 
double[][,] massive_for_pow_matrix = new double[z + 1][,]; //размер z+1 это важно
massive_for_pow_matrix[0] = array; // massive_for_pow_matrix[a] = array^(2^a)
//немного костылей, чтобы работало как на малых числах, так и на больших
int z1 = 1; 
if (z>0)
{
    z1 = z;
}
//z1 почти всегда равно z
bool flag = true;
//инициализация переменных и массивов

//main
while (flag)
{
    //доходим до A^n, где n-степ. двойки. 2^n ближ. число явл. степ. двойки для inputInt снизу
    if (pow * 2 <= inputInt)
    {
        ans = Multiply(ans, ans);
        pow *= 2;

         //изначально k=1;
        if (k <= z)
        {
            massive_for_pow_matrix[k] = ans;
        }
        k++;
    }
    //теперь надо немного "добрать" степень
    //тут уже нужно будет знать значение матриц в разных степенях.
    else
    {
        //если мы уже получили нужную матрицу, то просто вывод
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
        //если нужно просто домножить текущую матрицу на изначальную, делаем это и выводим
        if (pow+1==inputInt)
        {
            ans= Multiply(ans, massive_for_pow_matrix[0]);
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
        
        //тут происходит основной донабор в степени
        if (pow + (int)Math.Pow(2,z1) <= inputInt)
        {
            ans = Multiply(ans, massive_for_pow_matrix[z1]);
            pow += (int)Math.Pow(2,z1);

        }

        else
        {
            z1--;
        }

    }
}
//main
    
