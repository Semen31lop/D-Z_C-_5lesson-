
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] ded = new int[size];
    for (int i = 0; i < size; i++)
    {
        ded[i] = new Random().Next(minValue, maxValue);
    }
    return ded;
}
void PrintArray(int[] ded)
{
    for (int i = 0; i < ded.Length; i++)
{
    Console.Write($"{ded[i]}  ; ");
}
}
int[] array = GetArray(4, -15, 15);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length ; i += 2)
{
    sum = sum + array[i];
}


Console.WriteLine($"{array}-->{sum}");