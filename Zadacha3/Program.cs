//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int count = 1;
//while (count <= number)
//{
    //Console.Write(Math.Pow(count,2) + " ");
    //count++;
//}
//решение препода
int N = Convert.ToInt32(Console.ReadLine());
//int start = 1;
// while (start <= N)
// {
//     // Console.WriteLine(start*start); 
//     Console.WriteLine(Math.Pow(start,2));
//     start++;//start = start + 1;
// }
// (начало; условие; увеличение счетчика цикла)
for (int start = 1; start <= N; start++)
{
    Console.WriteLine(Math.Pow(start,2));
}
