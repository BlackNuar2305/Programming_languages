

float count = 1;
float sum = 0;
float del = 0;
double e = 0.0001;

while (true)
{
    del = 1 / count;
    if (del < e)
        break;
    sum += del;
    count++;
}
System.Console.WriteLine(sum);