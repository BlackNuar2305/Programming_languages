int ProductOfNumbers(int n)
{
    int op = 1;
    for (int i = 1; i <= n; i++)
        op *= i;
    return op;
}

int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ProductOfNumbers(number));