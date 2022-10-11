/*
int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] ans = new int[5];
for (int i = 1; i < 5; i++)
{
    ans[i - 1] = array[i];
}
ans[4] = array[0];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(ans[i]);
}
*/

/*
 * пересечение
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 3,7,8,9,10 };
int[] ans = new int[5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if(array1[i] < array2[j])
        {
            break;
        }
        if(array1[i] == array2[j])
        {
            ans[i]=array1[i];
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(ans[i]);
}
*/
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 3, 7, 8, 9, 10 };
int[] ans = new int[5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
         if (array1[i] < array2[j])
        {
            break;
        }
        if (array1[i] == array2[j])
        {
            ans[i] = array1[i];
            break;

        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(ans[i]);
}