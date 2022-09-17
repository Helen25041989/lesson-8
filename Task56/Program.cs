int n = 4; 
int[,] massiv = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Mассив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}
int[] summ = new int[n];

for(int i= 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        summ[i]+=massiv[i, j];
      
    }
}
int rowNumNin=0;
int min = summ[0];
for (int i= 1; i < n; i++)
{
    if (min > summ[i])
    {
        min = summ[i];
        rowNumNin = i;
    }
}
Console.WriteLine("номер строки с наименьшей суммой элементов: {0} строка",rowNumNin+1);