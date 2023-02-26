// Задача 2:
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе. Реализовать через функции.

int inputInt (string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}
int SumDigit(int number)
{
    int SumDig = 0;
    while (number != 0)
    {
        SumDig += number % 10;
        number /= 10;
    }
    if (SumDig >= 0)
    {
        return SumDig;
    }
    return SumDig * (-1);
}

int number = inputInt("Введите число");
System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigit(number)}.");