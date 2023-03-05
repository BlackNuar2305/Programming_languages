int w = Convert.ToInt32(Console.ReadLine());


if (w % 2 == 0)
{
    for (int i = 2; i < w; i = i + 2)
    {
        System.Console.WriteLine($"{i} and {w - i}");
    }
}