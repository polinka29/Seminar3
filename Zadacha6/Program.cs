// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
//14212 -> нет
//23432 -> да
//12821 -> да


Console.WriteLine("Введите 5ти значное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());

if (number1 == number5 && number2 == number4 && number3 == number3 && number4 == number2 && number5 == number1)
{
   Console.WriteLine("Это палиндром");
}
else  Console.WriteLine("Это не палиндром");



