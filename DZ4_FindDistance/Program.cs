// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
void GetCoordinates (int[] coordinates) // Метод заполения координат для точки
{
    Console.Write("Введите координату x: ");
    coordinates[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите координату y: ");
    coordinates[1] = int.Parse(Console.ReadLine());
    Console.Write("Введите координату z: ");
    coordinates[2] = int.Parse(Console.ReadLine());
}

int[] a = {0,0,0};
int[] b = {0,0,0};
double dist = 0;

Console.WriteLine("Введите координаты x, y, z для точки a: ");
GetCoordinates(a);
Console.WriteLine("Введите координаты x, y, z для точки b: ");
GetCoordinates(b);

dist = Math.Sqrt((b[0] - a[0]) * (b[0] - a[0]) + (b[1] - a[1]) * (b[1] - a[1]) + (b[2] - a[2]) * (b[2] - a[2]));

 Console.WriteLine("Расстояние между точками равно: " + dist);