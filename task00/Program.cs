// Написать программу, которая обменивает элементы первой строки и последней строки

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
FillMatrix (matrix);
Console.WriteLine();
Console.WriteLine("Первоначальная матрица:");
PrintMatrix (matrix);

int tmp=0;

for (int j=0; j<columns; j++)
{
    tmp = matrix[0,j];  
    matrix[0,j] = matrix[rows-1,j];
    matrix[rows-1,j] = tmp;
}

Console.WriteLine();
Console.WriteLine("Матрица, где поменяли местами первую и последнюю строку:");
PrintMatrix (matrix);