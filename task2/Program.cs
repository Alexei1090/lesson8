/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Второе задание");*/
 
int[,] matrix = {{3,4,5},
                {2,3,4},
                {7,8,2},
                {2,3,7}};
 
int sum = 0;
 
int index = 0;
 
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = 0;
 
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        temp += matrix[j, i];
    }
    if (temp < sum)
    {
        sum = temp;
 
        index = i;
    }
}
Console.WriteLine("Столбец: ");
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine(matrix[i, index]);
}

