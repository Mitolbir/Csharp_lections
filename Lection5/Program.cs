/* 
Собрать строку с числами от a до b, a <= b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
NumbersFor(a, b);
Console.WriteLine(NumbersFor(a, b));
*/

/* 
Собрать строку с числами от a до b, a <= b (рекурсией)

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
NumbersRec(a, b);
Console.WriteLine(NumbersRec(a, b));
*/

/* 
Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

Console.WriteLine(SumFor(10));
*/

/* 
Сумма чисел от 1 до n (рекурсией)

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumRec(10));
*/