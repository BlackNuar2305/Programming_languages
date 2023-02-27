int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;


if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

System.Console.WriteLine(max);