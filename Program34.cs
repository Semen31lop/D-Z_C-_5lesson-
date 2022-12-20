//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
int[] ded= new int[size];
for (int i = 0; i < size; i++)
{
    ded[i]= new Random().Next(minValue,maxValue);
}
return ded;
}
void PrintArray(int[] ded)
{
for (int i = 0; i < ded.Length; i++)
{
    Console.Write($"{ded[i]} ");
}
}
int[] array = GetArray(6, 100, 1000);
PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        count++;
Console.WriteLine($"{array}-->{count}");