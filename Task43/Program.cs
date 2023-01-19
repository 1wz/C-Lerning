double b1,k1,b2,k2;
double epsilon=0.000001;
b1=InputDouble("введите b1");
k1=InputDouble("введите k1");
b2=InputDouble("введите b2");
k2=InputDouble("введите k2");

if(EqualDouble(k1,k2,epsilon))
{
    if(EqualDouble(b1,b2,epsilon))
    {
        Console.WriteLine("прямые совпадают");
    }
    else
    {
        Console.WriteLine("прямые не пересекаются");
    }
    return;
}
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

double InputDouble(string massage)
{
    Console.WriteLine(massage);
    string input=Console.ReadLine();
    return double.Parse(input);
}
bool EqualDouble(double n1,double n2,double epsilon)
{
    return MathF.Abs((float)(n1-n2))<epsilon;
}