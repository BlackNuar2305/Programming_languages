int sum_number(int a)
{   
    int sum = 0;
    for (int i = 1; i <= a; i++)
        sum += i;
    return sum;
}

int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(sum_number(number));