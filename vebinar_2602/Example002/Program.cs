Random rnd = new Random();
int number = rnd.Next(100, 1000);

int first_number = number / 100;
int last_number = number % 10;
System.Console.WriteLine(number);
System.Console.Write(first_number);
System.Console.WriteLine(last_number);