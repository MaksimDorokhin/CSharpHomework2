// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}!");
}
else if (b == a * a)
{
    Console.WriteLine($"Число {b} является квадратом числа {a}!");
}
else
{
    Console.WriteLine($"Ни одно из введенных чисел не является квадратом второго!");
}