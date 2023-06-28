/*
Алгоритм с O(1)

*/
/*
int n = 5;
int[] array = new int[n];
for (int i = 0; i < 5; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(" ", array) + "]");
// Сложность алгоритма O(1) - вывести 1 элемент
// [4 ,5, 3, 1, 2]
// O(n)
// [1 ,2, 3, 4, 5] - после сортировки. O(n*log n) по основанию 2
// (5 + 1)/2*5 - быстрая сортирвка. O(1)
// n < n * log(n) + 1 - тогда быстрая сортировка медленнее
int summa = 0;
for (int i = 0; i < 5; i++)
{
    summa += array[i];
}
Console.WriteLine (summa);
//сложность O(n)
*/

//Таблица умножения

/* Мой вариант
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

 for (int i = 0; i < matrix.GetLength (0); i ++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength (1); j++) // columns = arr.GetLength (1)
        {
            matrix[i,j] = (i+1)*(j+1);
        }
    }

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i,j], 5}");
        }
    Console.WriteLine();
}
*/

/*Первый вариант
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=n; i ++)
    {
        for (int j = 1; j <=n; j++)
        {
            Console.Write (i * j);
            Console.Write ("\t");
        }
        Console.WriteLine();
    }
// O(n^2)
*/ 

// Второй вариант с матрицей
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i ++)
{
    for (int j = 0; j < n; j++)
    {
        //if ((i+ j) <= n)
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}

 for (int i = 0; i < n; i ++) // rows = arr.GetLength (0)
{
    for (int j = 0; j < n; j++) // columns = arr.GetLength (1)
    {
        Console.Write (matrix[i,j]);
        Console.Write (" ");
    }
    Console.WriteLine();
}
// O(n^2/2)