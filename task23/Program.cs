// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = GetNumber("Введите число N: ");

for (int i = 1; i <= n; i++)
{
    int cube = CalculateCube(i);
    Console.Write(cube + " ");
}

static int GetNumber(string prompt)
{
    Console.Write(prompt);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static int CalculateCube(int number)
{
    return number * number * number;
}