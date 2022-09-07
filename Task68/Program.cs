/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

Console.WriteLine("Вычислим функцию Аккермана");
Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.Write("Необходимо ввести два неотрицательных числа");
}
else
{
    int res = Askerman(numberM, numberN);
    Console.WriteLine($"A ({numberM}, {numberN}) = {res}");
}

int Askerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Askerman(m - 1, 1);
    return Askerman(m - 1, Askerman(m, n - 1));
}

