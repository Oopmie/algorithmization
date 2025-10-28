//Лабораторная работа 3. циклы с предусловием и постусловием
//вариант 11. высокий
Console.WriteLine("Введите последовательность чисел. 0 - завершение последовательности");
double a = 1;
do
{
    double y = int.Parse(Console.ReadLine());
    if (y == 0) break;
    if (y < 0) a *= y;
}
while (true);
Console.WriteLine($"Произведение чисел : {a}");

//for
//вариант 11. средний
Console.WriteLine("введите x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите предел");
int n = int.Parse(Console.ReadLine());
while (n == 0)
{
    Console.WriteLine("некорректное значение");
    Console.Write("введите предел: ");
    n = int.Parse(Console.ReadLine());
}
double W = 0;
int k = 1;
W += (Math.Pow(-1, 3 * k + 1) / (k - 5) * Math.Pow(x, k));
double P = 0;
int m = 1;
while (P > 8)
{
    Console.WriteLine("некорректное значение");
}
P *= ((m * m - 9) / (m - 2));
double S = 0;
S = W + P;
Console.WriteLine($"S = {S:f2}");

//вычисление бесконечных сумм
//вариант 11


//табулирование функций
//вариант 11. высокий
Console.WriteLine("-----------------------------");
Console.WriteLine("|     x       |       y     |");
Console.WriteLine("-----------------------------");
double f = 0;
for (double x1 = -1; x1 <= 1; x1 += 0.25)
{
    double u = Math.Pow(x1, 2) - Math.Asin(Math.Pow(x1, 2) * Math.PI / 180);
    if (x1 > Math.PI/180)
    {
        f = Math.Pow(u, Math.Abs(Math.Cos(x1*Math.PI/180)));
    }
    else if (x1 <= Math.PI/180)
    {
        f = Math.Pow(u, Math.Sin(x1 * Math.PI / 180));
    }
    Console.WriteLine($"|{x1,9:f2} {" ",-3}|{f,12:f2}{" "}|");
}
Console.WriteLine("-----------------------------");