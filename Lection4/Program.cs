/*
Вывод слова в ячейке [1,2]

string[,] table = new string[2,5];
//String.Empty
//table [0,0] table [0,1] ...
//table [1,0] table [1,1] ,,,
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/*
Вывод двумерного массива со случайной генерацией чисел

void PrintArray(int[,] matr)
{
    // i - rows, j - columns
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    // i - rows, j - columns
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //1 to 9
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int [3,4];
FillArray(matrix);
PrintArray(matrix);
*/

/*
Пример рекурсии

int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n==1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3));
*/