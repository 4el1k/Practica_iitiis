//012345678910 11 12
//0123456789 1 0  1  1121314151617181920212223......
//найти число которое стоит на k индексе.
//работает до 188
int k = 1889;
bool flag = true;
int n1 = 9;
int n2 = 0;
int i = 0;
while (flag)
{
    i++;
    if (k <= n1+n2)
    {
        flag = false;
        break;
    }
    n2 = n1;
    n1 = n1 * (int)Math.Pow(10, i);
}
Console.WriteLine(i);