// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

bool isPalindrome = IsPalindrome(number);

if (isPalindrome)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
    static bool IsPalindrome(int number)
{
    // Проверяем, что число является пятизначным
    if (number < 10000 || number > 99999)
    {
        return false;
    }
    
    // Преобразуем число в строку для удобства сравнения символов
    
    string numberString = number.ToString();

    // Сравниваем символы с обоих концов строки
    
    for (int i = 0; i < numberString.Length / 2; i++)
    {
        if (numberString[i] != numberString[numberString.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}