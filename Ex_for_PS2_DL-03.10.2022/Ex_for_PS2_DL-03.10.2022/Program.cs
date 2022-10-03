//ex 5
//(1+x)^a; -1<=x<=1
//Math.Round(a,b). a - число, b - кол-во знаков после запятой.
float x = 0.25f;
float a = 4.0f;
float summ = 1;
float powerX = 1;
float factorial = 1;
float multA = 1;
int i = 0;
int k = 3; //кол-во знаков после запятой, нужно для округления.
while (Math.Round(Math.Pow(1 + x, a),k)!=Math.Round(summ,k))
{
    multA *= a - i;
    powerX *= x;
    i++;
    factorial *= i;
    summ += multA * powerX / factorial;
}
Console.WriteLine($"{summ},{Math.Pow(1+x,a)}");