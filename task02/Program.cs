// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//                     или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillMatrix (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            m1[i,j]=new Random().Next(0,10);
        }
    }
}

void PrintMatrix (int [,] m2)
{
    for (int i=0; i<m2.GetLength(0); i++)
    {
        for (int j=0; j<m2.GetLength(1); j++)
        {
            Console.Write ($"{m2[i,j]}  ");
        }
    Console.WriteLine ();
    }
}

Console.Write ($"введите кол-во строк ");
int rows = int.Parse(Console.ReadLine () ?? "0");
Console.Write ($"введите кол-во столбцов ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [rows,columns];
if (rows!=columns)
    Console.WriteLine("Матрица долждна быть квадратной, введите одинаковое кол-во строк и столбцов.");
else
{
    FillMatrix (matrix);
    Console.WriteLine();
    Console.WriteLine("Первоначальная матрица:");
    PrintMatrix (matrix);

    int [,] mtr = new int [rows,columns];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
            mtr[j,i]=matrix[i,j];
    }
    Console.WriteLine();
    Console.WriteLine("Матрица :");
    PrintMatrix (mtr);
}