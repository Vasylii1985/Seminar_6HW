// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) Что то тут пошло не так(
Console.Write("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Линии пересекаются ");

    }
}
else
{
    int x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("Координаты точки х - " + x);

    int y = k1 * x + b1;
    Console.WriteLine("Координаты точки y - " + y);
}
