int n = 2;
int[,] massiv1 = new int[n, n];
int[,] massiv2 = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv1[i, j] = new Random().Next(1, 10);
        massiv2[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Mассив 1:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Mассив 2:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv2[i, j] + " ");
    }
    Console.WriteLine();
}
int[,] result = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int u = 0; u < n; u++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i,u] += massiv1[i,j] * massiv2[j,u];
        }
    }
}
Console.WriteLine("Результат:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}