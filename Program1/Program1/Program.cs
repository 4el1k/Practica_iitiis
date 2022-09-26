//0123456789
//1234567891011121314151617181920212223......
//найти число которое стоит на k индексе.
String str = "";
int k = int.Parse(Console.ReadLine());
for (int i = 1; i < k; i++)
{
    str=str + i.ToString();
}
Console.WriteLine($"{str[k]},{k}");