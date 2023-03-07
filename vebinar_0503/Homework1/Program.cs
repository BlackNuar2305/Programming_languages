int number = Convert.ToInt32(Console.ReadLine());


string s = number.ToString();
char [] ar = s.ToCharArray();
Array.Reverse(ar);
s = new string(ar);
int a = Convert.ToInt32(s);

if (number == a) System.Console.WriteLine("yes");
else System.Console.WriteLine("No");