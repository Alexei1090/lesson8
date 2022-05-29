/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:*/

using System;
Console.Clear();
Console.Write($"размер матрицы");
int s = int.Parse(Console.ReadLine());
int[,] arr = CetArray(s);
PrintArray(arr);

int[,] CetArray(int size)
{
    int[,] result = new int[size,size];
    int i = 0;
    int j = 0;
    int rowe = size - 1;
    int colume = size - 1;
    int rows = 0;
    int columns = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while(count<size*size)
    {
        count++;
        result[i,j] = count;
        if(left&&top)
        {
            if(j==colume)
            {
                rows++;
                top=true;
                left=false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        if(!left&&top)
        {
            if(i==rowe)
            {
                colume--;
                top=false;
                left=false;
                j--;
                continue;        
            }
            else
            {
                i++;
                continue;
            }
        }
        if(!left&&!top)
        {
            if(j==columns)
            {
                rowe--;
                top=false;
                left=true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        if(left&&!top)
        {
            if(i==rows)
            {
                columns++;
                top=true;
                left=true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }       
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0;j<inArray.GetLength(1); j++)
        {
            string el = inArray[i,j]<10?" "+inArray[i,j]:inArray[i,j].ToString();
            Console.Write($"{el} ");
        }
        Console.WriteLine();
    }  
}