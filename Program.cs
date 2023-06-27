/*
Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string GetStringOfNumbers(int start, int end)
{
    // Базовый случай - выход
    if (start == end) return start.ToString();
    // Рекурсивный случай
    return start + ", " + GetStringOfNumbers(start - 1, end);

}
Console.WriteLine(GetStringOfNumbers(N, 1));
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
Console.Write("Введите число N: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int N = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(M, N);
void SumOfNumbers(int M, int N)
{
    Console.Write(GetSumOfNumbers(M - 1, N));
}
int GetSumOfNumbers(int M, int N)
{
    int res = M;
    if(M==N) return 0;
    else
    {
        M++;
        res = M + GetSumOfNumbers(M, N);
        return res;
    }
}
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetAkkermanFunction(m,n);
void GetAkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}