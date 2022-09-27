//012345678910 11 12
//0123456789 1 0  1  1121314151617181920212223......
//найти число которое стоит на k индексе.
//работает до 188
int k = int.Parse(Console.ReadLine());
int n;
n = k;
if (k < 100)
{
    while (n >= 10)
    {
        n /= 10;
    }
}
else
{
    n = n - (n % 100) * 100;
    while (n >= 10)
    {
        n /= 10;
    }
}
bool left=false, right=false;
if ((k % 10 != 0) && ((k - 1) % 10 != 0) && ((k + 1) % 10 != 0))
{
    if (n % 2 == 0)
    {
        right = true;
    }
    else
    {
        left = true;
    }
    if (right)
    {
        if (k % 2 == 0)
        {
            int b;
            b = (k % 10) + (((10 - k % 10)) % 10) / 2;
            Console.WriteLine(b);
        }
        else
        {
            int b;
            b = (k % 10) / 2;
            Console.WriteLine(b);
        }
    }
    else
    {
        if (k % 2 == 0)
        {
            int b;
            b = (k % 10) / 2;
            Console.WriteLine(b);
        }
        else
        {
            int b;
            b = (k % 10) / 2 + 1;
            Console.WriteLine(b);
        }
    }
}
else
{
    if (k % 10 == 0)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(5);
        }
        else
        {
            Console.WriteLine(0);
        }
        Console.WriteLine("первый иф");
    }
    if ((k - 1) % 10 == 0)
    {
        Console.WriteLine(n / 2);
        
    }
    if ((k + 1) % 10 == 0)
    {
        Console.WriteLine(n / 2 + 1);
    }
    
}
string str = "";
for (int i = 1; i < k+1; i++)
{
    str = str + i.ToString();
}
Console.WriteLine(str[k]);