int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
    System.Console.WriteLine((number / 10) % 10);
}
else System.Console.WriteLine("number is not three digit");