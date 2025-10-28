//Лабораторная работа 2. Логические выражения
//Вариант 18. Высокий
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(y>=x*x-2&&y<=x);

//Условные операторы
//Вариант 15. Высокий
Console.WriteLine("Введите координаты трех вершин:");

Console.Write("Вершина 1: ");
string[] v1 = Console.ReadLine().Split();
int x1 = int.Parse(v1[0]);
int y1 = int.Parse(v1[1]);

Console.Write("Вершина 2: ");
string[] v2 = Console.ReadLine().Split();
int x2 = int.Parse(v2[0]);
int y2 = int.Parse(v2[1]);

Console.Write("Вершина 3: ");
string[] v3 = Console.ReadLine().Split();
int x3 = int.Parse(v3[0]);
int y3 = int.Parse(v3[1]);

int x4 = x1 ^ x2 ^ x3;
int y4 = y1 ^ y2 ^ y3;

Console.WriteLine($"Четвертая вершина: {x4} {y4}");