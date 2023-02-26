Random rnd = new Random();
int number = rnd.Next(1, 100);

int num1 = number / 10;
int num2 = number % 10;
System.Console.WriteLine(number);
if (num1 > num2) System.Console.WriteLine(num1);
else System.Console.WriteLine(num2);