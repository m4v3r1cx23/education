var matrix = generateMatrix();
var sum = diagonalSum(matrix);

displayMatrix(matrix);
displaySum(sum);

static int[,] generateMatrix()
{
    int[,] matrix = new int[10, 10];

    for (var i = 0; i < 10; i++)
    {
        for (var j = 0; j < 10; j++)
        {
            if (i == j)
            {
                matrix[i, j] = i;
            }
            else
            {
                matrix[i, j] = 0;
            }
        }
    }

    return matrix;
}

static int diagonalSum(int[,] matrix)
{
    var sum = 0;

    for (var i = 0; i < 10; i++)
    {
        sum += matrix[i, i];
    }

    return sum;
}

static void displayMatrix(int[,] matrix)
{
    for (var i = 0; i < 10; i++)
    {
        for (var j = 0; j < 10; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}

static void displaySum(int sum)
{
    Console.WriteLine($"Sum of diagonal elements: {sum}");
}