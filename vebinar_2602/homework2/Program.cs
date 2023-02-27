int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) System.Console.WriteLine("no third digit");

while (number >= 1000) number /= 10;

System.Console.WriteLine(number % 10);
