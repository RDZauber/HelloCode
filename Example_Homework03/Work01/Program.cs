// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да
// 0  1  2  3  4
// 1, 4, 2, 1, 2

Console.Write("Введите число: ");
string? array = Console.ReadLine();
void Checkingarray(string array)
{
    if (array[0] == array[4] || array[1] == array[3])
    {
        Console.WriteLine("Ваше число - палиндром.");
    }
    else Console.WriteLine("Ваше число - НЕ палиндром.");
}

if (array!.Length == 5)
{
    Checkingarray(array);
}
else Console.WriteLine("Пожалуйста введите пятизначное число");