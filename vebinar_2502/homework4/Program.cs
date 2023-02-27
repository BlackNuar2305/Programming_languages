int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= number)
{
    if (index % 2 == 0) System.Console.WriteLine(index);
    index++;
}