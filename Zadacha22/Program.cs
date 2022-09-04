// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//Console.Write("Введите координату по оси оХ: ");
//int x1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату по оси оY: ");
//int y1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату 2 по оси оХ: ");
//int x2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату 2 по оси оY: ");
//int y2 = Convert.ToInt32(Console.ReadLine());

//double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
//Console.WriteLine($"result = {Math.Round(result,2)}");
//задача 21 делал препод
Console.Write("Координата х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// B
Console.Write("Координата х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"Расстояние = {Math.Round(d,3)}");
Console.WriteLine($"Расстояние = {d:f3}");

// переменная:fсколько_знаков
