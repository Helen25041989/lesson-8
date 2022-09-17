int n = 2;
int[,,] massiv = new int[n, n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int u = 0; u < n; u++)
        {
            massiv[i, j,u] = new Random().Next(10, 99);
        }
    }
}
Console.WriteLine("Mассив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int u = 0; u < n; u++)
        {
            Console.Write(String.Format("{0}({1},{2},{3}) ",massiv[i, j, u],i,j,u));
        }
    }
    Console.WriteLine();
}