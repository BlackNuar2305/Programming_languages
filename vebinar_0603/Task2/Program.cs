int number_of_digits(int number)
{
    int n = 0;
    int count = 0;
    while (n < number)
    {
        number = number / 10;
        n++;
        count++;
    }
    return count;
}

int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(number_of_digits(number));