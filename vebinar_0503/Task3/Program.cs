int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());

int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));
System.Console.WriteLine(result);