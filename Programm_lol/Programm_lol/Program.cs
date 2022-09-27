//5
/*
float a, x,summ=1;
x=float.Parse(Console.ReadLine());
a=float.Parse(Console.ReadLine());
int i = 0;
a += 1;
float powerX = 1, fact=1, peremen_znach;
while (Math.Pow(1+x,a)!=summ)
{
    i++;
    fact *= i;
    powerX *= x*(a-i);
    summ += powerX / fact;
}
Console.WriteLine($"{summ},{Math.Pow(1+x,a)}");
*/
int x = int.Parse(Console.ReadLine());
bool flag,flag1;
for (int i = 2; i < Math.Pow(x,0.5)+1; i++)
{
    flag1 = true;
    flag = true;
    if (x % i == 0)
    {
        if (x / i != i)
        {
            for (int j = 2; j < Math.Pow(i, 0.5) + 1; j++)
            {
                if (j != i)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
                for (int j = 2; j < Math.Pow(x/i, 0.5) + 1; j++)
            {
                
                
                if ((x / i) % j == 0)
                {
                    flag1 = false;
                    break;
                }
                
            }
            if (flag)
            {
                Console.WriteLine(i);
            }
            if (flag1)
            {
                Console.WriteLine(x/i);
            }


        }
        else
        {
            for (int j = 2; j < Math.Pow(i, 0.5) + 1; j++)
            {
                if (i % j == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine(i);
            }
        }
    }
}