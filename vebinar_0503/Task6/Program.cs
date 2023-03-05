int number = Convert.ToInt32(Console.ReadLine());
string count(int n)
{
    string numberOfGratings = string.Empty;
    for (int i = 0; i < n; i++)
    {
        numberOfGratings += "#";
    }
    return numberOfGratings;
}

string space(int n)
{
    n = (n - 1) / 2;
    int i = 0;
    string numberOfSpace = string.Empty;
    while (i < n)
    {
        numberOfSpace += " ";
        i++;
    }
    return numberOfSpace;
}

int n = number;

for (int i = 1; i <= number; i += 2)
{
        System.Console.WriteLine($"{space(n)}{count(i)}{space(n)}");
        n -= 2;
} 