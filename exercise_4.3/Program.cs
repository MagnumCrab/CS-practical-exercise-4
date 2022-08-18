//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

Console.WriteLine("Задайте количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];

for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + numbers[i] + " ");
}