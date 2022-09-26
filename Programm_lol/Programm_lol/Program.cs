double x, y;
x = double.Parse(Console.ReadLine());
y= double.Parse(Console.ReadLine());
if((x*x<=1 && y>=0 && y<=1 && (Math.Abs(x)+Math.Abs(y)<=1 )) || (x*x<=1 && y<=0 && y<=-1*x*x))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}





