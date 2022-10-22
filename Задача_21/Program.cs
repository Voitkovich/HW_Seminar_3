// Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

double Distanse3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}

Console.WriteLine("Введите х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distanse3D(x1, x2, y1, y2, z1, z2);
Console.WriteLine(distance);
