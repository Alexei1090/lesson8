/*Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/

using System;
Console.Clear();

int m = 3;
int n = 3;

int [,]array=GetArray(m,n);
for (int K=0; K<m; K++)
{
    for (int R=0; R<n; R++)
    {
        Console.Write($"{array[K,R]} ");
    } 
    Console.WriteLine();
}


int [,]arr=array;
for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j / m, j % m] > arr[(j + 1) / m, (j + 1) % m])
                {
                    int temp = arr[j / m, j % m];
                    arr[j / m, j % m] = arr[(j + 1) / m, (j + 1) % m];
                    arr[(j + 1) / m, (j + 1) % m] = temp;
                    
                }
            Console.Write(arr[i,j]);    
            }
        Console.WriteLine();    
        }



int[,] GetArray(int r, int c)
{
    int[,] res = new int[r , c];
    for(int i=0; i<r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            res[i,j]=new Random().Next(1,10);
        }
    }

    return res;
}