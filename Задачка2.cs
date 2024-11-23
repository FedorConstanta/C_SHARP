int [] massiv = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter {i} number of array: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n >= -7 && n <= 7)
        massiv[i] = n;
        Console.WriteLine(massiv[i]);
    Console.WriteLine($"Last element of massiv: { massiv[9]} ");

}
