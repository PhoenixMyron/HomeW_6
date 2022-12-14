// extra 2

Console.Write("Введите x1 и y1 : ");
string[] firstNumbers = Console.ReadLine().Split(" ");
double x1 = double.Parse(firstNumbers[0]);
double y1 = double.Parse(firstNumbers[1]);
Console.Write("Введите x2 и y2 : ");
string[] secondNumbers = Console.ReadLine().Split(" ");
double x2 = double.Parse(secondNumbers[0]);
double y2 = double.Parse(secondNumbers[1]);
Console.Write("Введите x3 и y3 : ");
string[] thirdNumbers = Console.ReadLine().Split(" ");
double x3 = double.Parse(thirdNumbers[0]);
double y3 = double.Parse(thirdNumbers[1]);
double summ = ((x1 - x3) * (y2 - y3)) - ((x2 - x3) * (y1 - y3)) ;
Console.WriteLine($"{(summ * (-1)) / 2} ");

