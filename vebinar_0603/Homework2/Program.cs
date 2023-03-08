int sum_of_digits(int number)
{
    int i = 0;
    int summ = 0;
    while (i < number)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(sum_of_digits(number));