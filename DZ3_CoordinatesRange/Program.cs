// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
if (quarter == 1)
{
    Console.WriteLine("Возможный диапазон по оси X: от 0 до + \u221e; по оси Y: от 0 до + \u221e");
}
else if (quarter == 2)
{
    Console.WriteLine("Возможный диапазон по оси X: от - \u221e до 0; по оси Y: от 0 до + \u221e");
}
else if (quarter == 3)
{
    Console.WriteLine("Возможный диапазон по оси X: от - \u221e до 0; по оси Y: от - \u221e до 0");
}
else if (quarter == 4)
{
    Console.WriteLine("Возможный диапазон по оси X: от 0 до + \u221e; по оси Y: от - \u221e до 0");
}
else
{
    Console.WriteLine("Введенный номер не соответствует ни одной координатной четверти!");
}