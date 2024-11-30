Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    int randomNumber = random.Next(-7, 7);
    array[i] = randomNumber;
    Console.Write($"{randomNumber}, ");
}

Console.WriteLine();
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_index = -1;
for (int i = 0; i < 10; i++)
{
    if (number == array[i])
        number_index = i;
    Console.WriteLine($"index = {number_index} ");
}
