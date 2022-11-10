Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine("(" + y1 + "; " + y2 + ")");

