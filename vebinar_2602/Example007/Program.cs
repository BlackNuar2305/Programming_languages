int number = Convert.ToInt32(Console.ReadLine());
int square = 1;

while (square * square <= number)
{
    System.Console.WriteLine(square * square);
    square++;
}