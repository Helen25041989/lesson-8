int m = 3;//строки
int n = 4; //столбцы
int[,] massiv = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Mассив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}
int[] temp = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        temp[j] = massiv[i, j];
    }
    Array.Sort(temp);
    Array.Reverse(temp);
    for (int k = 0; k < n; k++)
    {
        massiv[i, k] = temp[k];
    }
  
}

Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}