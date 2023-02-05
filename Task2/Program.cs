// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void SortToLower(int[,] array) // функция упорядочивания по убыванию элементов каждой строки двумерной массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {            
            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
            }           
        }
    }
}
void PrintArray(int[,] matr) // функция просматривает массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr) // функция заполняет массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}
///////////////////////////////////
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
SortToLower(array);
Console.WriteLine();
PrintArray(array);