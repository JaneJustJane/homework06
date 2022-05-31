// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns-1; j++)
    {
        for (int k=j+1; k<columns; k++)
            if (matrix[i,k]>matrix[i,j])
            {
                tmp=matrix[i,j];
                matrix[i,j]=matrix[i,k];
                matrix[i,k]=tmp;
            }
    }
}
Console.WriteLine();
Console.WriteLine("Матрица отсортированная по убыванию:");
PrintMatrix (matrix);



