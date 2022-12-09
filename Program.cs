// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    double [,] created2dArray = new double [row, column];
    for (int i=0; i <row; i++)
        for (int j=0; j < column; j++)
        {
        created2dArray [i,j]=new Random().Next(minVal, maxVal+1)+new Random().NextDouble();
        created2dArray [i,j] = Math.Round(created2dArray[i,j], 1);
        }
        return created2dArray;
}

void Show2dArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write ("Input count of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input min possible value: ");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32 (Console.ReadLine());

double [,] newArray = Create2dArray (rows,columns,min,max);
Show2dArray(newArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int [,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int [row, column];
    for (int i=0; i<row; i++)
        for (int j=0; j<column; j++)
        created2dArray [i,j]=new Random().Next(minVal+maxVal+1);
        return created2dArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumElements (int [,] array)
{
    Console.WriteLine ("Input number of row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input number of column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    {
       if (row>=array.GetLength(0)&&column>=array.GetLength(1))
       Console.WriteLine (" there is no such number");
       else Console.WriteLine ($" there is the number: {array[row,column]}");
   }
}

int [,] newArray = Create2dArray(4,4,2,5);
Show2dArray(newArray);
NumElements(newArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Created2dArray (int row, int column, int minVal, int maxVal)
{
    int [,] created2dArray = new int [row,column];
    for (int i=0; i<row; i++)
        for (int j=0; j<column; j++)
        created2dArray [i,j] = new Random().Next(minVal, maxVal+1);
        return created2dArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double [] NewColumn (int [,] array1)
{
    double [] numSum = new double [array1.GetLength(1)];
    for (int j=0; j<array1.GetLength(1); j++)
    {
        double sum=0;
        for (int i=0; i<array1.GetLength(0); i++)
        {
            sum+=array1[i,j];
        }
        numSum[j]=Math.Round(sum/array1.GetLength(0),2);
    }
    return numSum;
}

void ShowArray (double [] array)
{
    for (int i=0; i<array.Length; i++)
     Console.Write (array[i] + " ");
}
  
Console.Write ("Input count of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input min possible value: ");
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32 (Console.ReadLine());

int [,] array2d = Created2dArray (rows, columns, min, max);
Show2dArray(array2d);
double [] array1d = NewColumn(array2d);
ShowArray(array1d);
