int number = Convert.ToInt32(Console.ReadLine());

if ((number > 0) && (number < 8))
{
    if ((number == 6) || (number == 7)) System.Console.WriteLine("Yes");
    else System.Console.WriteLine("No");
}
else System.Console.WriteLine("Enter a number from one to seven");