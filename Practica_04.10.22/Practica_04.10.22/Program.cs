int n = 20;
int[] array = new int[n];
Random rand = new Random();
int maxNegative = -999, minPositive = 999; 
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(-100,100);
    if(array[i] < 0)
    {
        if(array[i] > maxNegative)
        {
            maxNegative = array[i];
        }
    }
    if (array[i] > 0)
    {
        if (array[i] < minPositive)
        {
            minPositive = array[i];
        }
    }
}
Console.WriteLine($" {maxNegative},{minPositive}");
int maxIndex = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] >= maxIndex)
    {
        maxIndex = i;
    }
}
Console.WriteLine(maxIndex);
int minElement = 9999999, count=0;
int[] array1 = new int[5] {3,4,6,7,3};
int predposledn = 0, indexLastMin;
for (int i = 0; i < 5; i++)
{
    if (array1[i] == minElement)
    {
        count++;
        indexLastMin=i;
    }

    if (array1[i] < minElement)
    {
        indexLastMin=i;
        predposledn = minElement;
        count = 0;
        minElement = array1[i];
        count++;
    }
    

}
Console.WriteLine(count*minElement);

int k=5;
int[] bebra = new int[k];
bool flag, flagGlobal=false;
for (int i = 0; i < k; i++)
{
    flag = true;
    bebra[i] = rand.Next(100);
    for (int j = 2; j < (int)(Math.Pow(bebra[i], 0.5) + 1); j++)
    {
        if (bebra[i] != j)
        {
            if (bebra[i] % j == 0)
            {
                flag = false;
                break;

            }
        }
    }
    if (flag)
    {
        Console.WriteLine("есть простые числа");
        flagGlobal = true;
        break;
    }
}
if (!flagGlobal)
{
    Console.WriteLine("простых чисел нет =(");
}

int[] array2 = new int[5] { 1, 7, 9, 3, 9 };
for (int i = 0; i < 5-1; i++)
{
    for (int j = i+1; j < 5; j++)
    {
        if (array[i] == array[j])
        {
            Console.WriteLine("есть повторяющиеся числа");
        }
    }
}