double N = Convert.ToDouble(Console.ReadLine());
double M = Convert.ToDouble(Console.ReadLine());

M = 1 + M / 100;

double K = Convert.ToDouble(Console.ReadLine());
double Q = Convert.ToDouble(Console.ReadLine());

Q = 1 + Q / 100;

int count = 0;

if (Q > M)
{
    System.Console.WriteLine("despair");
}
else
{
    while (N < K)
    {
        N *= M;
        K *= Q;
        count += 1;
    }
}
System.Console.WriteLine(count);