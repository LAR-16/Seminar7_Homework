void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Введите позицию искомого элемента: ");
int[] find = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (matrix.GetLength(1) < find[1] || matrix.GetLength(0) < find[0])
    Console.Write("Такой позиции в массиве нет");
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == find[0]-1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == find[1]-1)
                    Console.WriteLine($"Искомый элемент = {matrix[i,j]}");
                
            }
        }
    }
