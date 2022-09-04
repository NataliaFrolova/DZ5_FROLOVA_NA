// // Задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

int[] array = {5, 7, 27, 11, 90};
int min = array[0];
int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        
        if (array[i] > max) max = array[i];
    }
Console.WriteLine($"[{string.Join(", ", array)}] -> {max - min}");
