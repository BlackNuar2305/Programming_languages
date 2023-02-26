float n = Convert.ToInt32(Console.ReadLine());

float count = 1;
float sum = 0;
float del = 0;

while (count <= n)
{
    del = 1 / count;
    sum += del;
    count++;
}
System.Console.WriteLine(sum);