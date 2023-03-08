void array_filling(int[] array, int minValue, int maxValue)
{   
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(minValue, maxValue + 1);
        }
}

int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[8];
array_filling(mass, min, max);

System.Console.WriteLine(string.Join(",", mass));