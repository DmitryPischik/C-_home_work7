// Написать программу, которая обменивает элементы первой строки и последней строки

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

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
// Обмениваеv элементы первой строки и последней строки:
for(int j=0; j < array.GetLength(1); j++)
{
    int temp = array[0, j];
    array[0, j] = array[m - 1, j];
    array[m - 1, j] = temp;          
}
Console.WriteLine();
PrintArray(array);
