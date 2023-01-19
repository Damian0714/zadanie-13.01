double Plos(double a, double b, double c)
{
    double P = ((double)a + (double)b + (double)c) / 2;
    double S = Math.Sqrt(P * (P - (double)a) * (P - (double)b) * (P - (double)c));
    return S;
}

double S = 0.0;
double a, b, c;

Console.WriteLine("Ввод строн a,b,g");

a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
S += Plos(a, b, c);
Console.WriteLine("Введите f,c");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
S += Plos(a, b, c);
Console.WriteLine("Введите e,d");
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
S += Plos(a, b, c);
Console.WriteLine(S);
