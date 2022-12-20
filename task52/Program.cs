// НЕПРАВИЛЬНО считает. переделать

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// void FindAverage(int[,] matrix)
// {
//     double sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//             sum = sum + matrix[i, j];
//             }
//             Console.WriteLine(sum/size[0]);
//     }
// }

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
// FindAverage(matrix);
double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
            sum = sum + matrix[i, j];
            }
            Console.WriteLine(Math.Round(sum/size[0], 2));
    }