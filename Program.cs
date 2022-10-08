/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
 каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

int[,] GenerateArray(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] MassivSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxNumberPos = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxNumberPos])
                {
                    maxNumberPos = k;
                }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxNumberPos];
            matrix[i, maxNumberPos] = temp;
        }
    }
    return matrix;
}
int[,] myArray = GenerateArray(3, 4);
PrintArray(myArray);
PrintArray(MassivSort(myArray));*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка

int[,] GenerateArray(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int RowMinSum(int[,] matrix)
{
    int minSum = matrix[0, 0];
    int rowMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    return rowMinSum + 1;
}
int[,] myArray = GenerateArray(3, 4);
PrintArray(myArray);
System.Console.WriteLine($" Строка с наименьшей суммой элементов: {RowMinSum(myArray)}"); */

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
int[,] GenerateArray(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            { matrix3[i, j] += matrix1[i, k] * matrix2[k,j]; }
        }
    }
    return matrix3;
}
int [,] array1 = GenerateArray(2,3);
PrintArray(array1);
int [,] array2 = GenerateArray(3,4);
PrintArray(array2);
int [,] newArray = MatrixProduct(array1,array2);
System.Console.WriteLine("Результирующая матрица:");
PrintArray(newArray);*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int[,,] Generate3DArray(int rows, int colums, int lines)
{
    int[,,] array = new int[rows, colums, lines];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = (int)(Math.Pow(i + 1, 3) + Math.Pow(j + 2, 3) + Math.Pow(k + 3, 3));
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k})");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,,] myArray = Generate3DArray(2, 2, 2);
Print3DArray(myArray);*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
int[,] GenerateSriralArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    int count = 1;
    int startRow = 0;
    int endRow = array.GetLength(0) - 1; 
    int starColum = 0;
    int endColum = array.GetLength(1) - 1;
    while(startRow<=endRow && starColum<=endColum){
        for (int j = starColum; j <= endColum; j++)
        {
            array[startRow,j] = count;
            count++;
        }
        startRow++;
        for (int i = startRow; i <=endRow; i++)
        {
            array[i,endColum] = count;
            count++;
        }
        endColum--;
        for (int j = endColum; j >= starColum; j--)
        {
            array[endRow,j]=count;
            count++;
        }
        endRow++;
        for (int i = endRow; i >= startRow; i--)
        {
            array[i,starColum]=count;
            count++;
        }
        starColum--;
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,] myarray = GenerateSriralArray(4,4);
PrintArray(myarray);
