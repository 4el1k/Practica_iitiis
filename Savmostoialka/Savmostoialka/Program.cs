//1 zada4a
int n = 10;
int[] array = new int[10] {1,2,67,1,2,3,-3,8,9,6};
int min = 9999999, max = -999999, indexMin=0, indexMax=0;
for (int i = 0; i < n; i++)
{
    if(array[i] < min)
    {
        min = array[i];
        indexMin = i;
    }
    if(array[i] > max)
    {
        max = array[i];
        indexMax = i;
    }
}
int sum = 0, stacan;
if (indexMin > indexMax)
{
    stacan = indexMin;
    indexMin = indexMax;
    indexMax = stacan;
}
for (int i = indexMin+1; i < indexMax; i++)
{
    sum+=array[i];
}
Console.WriteLine(sum);