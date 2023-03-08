void random_massiv()
{
    Random rnd = new Random();
    int[] massiv = new int[8];

    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(0, 2);
    }
    Console.WriteLine(string.Join(",", massiv));
}
random_massiv();
