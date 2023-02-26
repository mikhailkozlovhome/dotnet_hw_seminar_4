// Задача 1:
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Реализовать через функции.
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

bool ValidatePower (int pow)
{
    if (pow <= 0)
    {
        System.Console.WriteLine($"Число {pow} не является натуральным!");
        return false;
    }
    return true;
}

int power (int number, int pow)
{
    int result = 1;

    for (int i = 1; i <= pow; i++)
    {
        result = result * number;
    }

    return result;
}

int A = inputInt("Введите число которое необходимо возвести в степень");
int B = inputInt("Введите натуральную степень в которую необходимо возвести число");

if (ValidatePower(B))
{
    System.Console.WriteLine($"Число {A} в степени {B} равно {power(A, B)}");
}