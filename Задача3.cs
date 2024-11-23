int [] massiv = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter {i} number of array: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n >= -10 && n <= 10)
        massiv[i] = n;
        Array.Sort(massiv);
    Console.WriteLine(massiv[9]);

}
