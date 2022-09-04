// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

Console.Write("Введите координату по оси оХ: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату 2 по оси оХ: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату 2 по оси оY: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату 3 по оси оХ : ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату 3 по оси оY : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
Console.WriteLine($"result = {Math.Round(result,2)}");
