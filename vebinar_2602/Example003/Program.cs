int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number % second_number == 0)
{
    System.Console.WriteLine("multiple");
}
else
{
    System.Console.WriteLine($"not a miltiple, remainder {first_number % second_number}");
}