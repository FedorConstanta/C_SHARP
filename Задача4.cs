

using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

Random random = new Random();
int[,] array = new int[4, 4];


for (int i = 0; i < 4; i++)
{
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = random.Next(-5, 5);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
}

   
int min = array[0, 0];

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
    }

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (array[i, j] % 2 == 0)
        {
            int temp = array[i, j] * 2;
            array[i, j] = temp;
        }
        else
        {
            int temp = array[i, j] * 3;
            array[i, j] = temp;
        
        }

    }
}

Console.WriteLine("--------------");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


Console.WriteLine($"Минимальное значение в массиве: {min}");


