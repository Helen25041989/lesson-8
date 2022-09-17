int n = 4;
int[,] massiv = new int[n, n];


int row = 0;
int col = 0;
int x = 1;
int y = 0;
int dir = 0;
int v= n;

for (int i = 0; i < massiv.Length; i++)
{
    massiv[row, col] = i + 1;
    if (--v == 0)
    {
        v = n * (dir % 2) + n * ((dir + 1) % 2) - (dir / 2 - 1) - 2;
        int temp = x;
        x = -y;
        y = temp;
        dir++;
    }

    col += x;
    row += y;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
       
       Console.Write(massiv[i, j].ToString("D2")+" ");
       
    }
    Console.WriteLine();
}