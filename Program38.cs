//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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
int[] array = GetArray(5, -5, 20);
PrintArray(array);

int min = 0;
int max=1;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}

Console.WriteLine($"{array}-->{max-min}");