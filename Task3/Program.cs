// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n++;
        return n;
    }
    else
    {
        if (m > 0 && n == 0)
        {
            n = Akkerman(m - 1, 1);
        }
        else
        {
            n = Akkerman(m, n - 1);
            n = Akkerman(m - 1, n);
        }
    }
    return n;
}

int userM = Prompt("Для вычисления функции Аккермана А(m,n) введите число m");
int userN = Prompt("Для вычисления функции Аккермана А(m,n) введите число n");
System.Console.WriteLine("Функция Аккермана от введенных Вами чисел равна:" 
    + $" A(m, n) = {Akkerman(userM, userN)}");