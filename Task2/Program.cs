// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m > n) return 0;
    int sum = m + SumNumbers(m + 1, n);
    return sum;
}

int userM = Prompt("Введите первое число");
int userN = Prompt("Введите второе число");
System.Console.WriteLine(SumNumbers(userM, userN));