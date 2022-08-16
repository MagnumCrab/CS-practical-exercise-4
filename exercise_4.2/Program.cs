//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите любое число");
int i = Convert.ToInt32(Console.ReadLine());
int number1 = 0;

while (i > 0)
{
    int number2 = i % 10;
    i = i / 10;
    number1 = number1 + number2;
}
Console.WriteLine("Сумма цифр в числе равна: " + number1);