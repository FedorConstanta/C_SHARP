
float a = 3.14f;
float b = 30.6f;
// Все вещественные числа рассматриваются как double
decimal c = 1005.8M;
decimal d = 334.8M;

uint g = 10U;
long h = 11L;
ulong j = 12UL;

var Hello = "Hello, World !";
// Компилятор сам поймет какого типа данных переменная

// Этот код работает
int k;
k = 3;

// Этот код не работает

// var l;
// l = 5;

// Удалить переменную 
// Hello = null;

Console.Write("Введите свое имя: ");
String? name = Console.ReadLine();
Console.WriteLine(name);

if (name == "")
    Console.WriteLine("Hello idiot, why didnt you write your name");
else
    Console.WriteLine("ABCD ERROR");

switch (name)
{
    case "Bob": Console.WriteLine("Ваше имя - Bob"); break;
        ;
}

int x = 3;
int y = 2;
int z = x < y ? (x+y) : (y-x);
Console.WriteLine(z);

Console.WriteLine($"a = {a}"); // Сложный вариант
Console.WriteLine("a: " + a); // Скуф мод вариант
Console.WriteLine("b: " + b);
Console.WriteLine("c: " + c);
Console.WriteLine("d: " + d);
Console.WriteLine("g: " + g);
Console.WriteLine("h: " + h);
Console.WriteLine("j: " + j);
Console.WriteLine("Hello: " + Hello);
