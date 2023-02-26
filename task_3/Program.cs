// Задача 3:
// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int inputInt(string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}

bool ValidateSize(int SizeArray)
{
    if (SizeArray > 0)
    {
        return true;
    }
    System.Console.WriteLine("Колличество элементов массива должно быть больше 0!");
    return false;
}

bool ValidateRndminRndmax(int RndMin, int RndMax)
{
    if (RndMin <= RndMax)
    {
        return true;
    }
    System.Console.WriteLine("Минимальный порог случайных чисел должен быть меньше или равен максимальному порогу!");
    return false;
}

void FillArray(int[] Array, int RndMin, int RndMax)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(RndMin, RndMax + 1);
    }
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i < Array.Length - 1)
        {
            System.Console.Write($"{Array[i]}, ");
        }
        else
        {
            System.Console.Write($"{Array[i]}");
        }
    }
    System.Console.WriteLine();
}

int ArrSize = inputInt("Введите количество элементов массива");
int RndMin = inputInt("Введите минимальный порог случайных значений");
int RndMax = inputInt("Введите максимальный порог случайных значений");

if (ValidateSize(ArrSize) && ValidateRndminRndmax(RndMin, RndMax))
{
    int[] MyArray = new int[ArrSize];
    FillArray(MyArray, RndMin, RndMax);
    PrintArray(MyArray);
}

