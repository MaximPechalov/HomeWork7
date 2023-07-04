Console.Clear();

int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] SetArray2Double(int line, int column)
{
    double[,] numArr2D = new double[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 100);
            numArr2D[i, j] = Math.Round(numArr2D[i, j], 2);
        }
    }
    return numArr2D;
}

void PrintArray2Double (double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = InputNum ("Enter strings: ");
int n = InputNum ("Enter columns; ");

double[,] array = SetArray2Double(m, n);

Console.WriteLine($"Your massive {m}x{n}: ");
PrintArray2Double(array);