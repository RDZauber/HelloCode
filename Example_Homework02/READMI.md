
## Задание № 1.
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int value = 456;


int b = (value / 10) % 10;

Console.WriteLine(" Вторая цифра числа ");
Console.WriteLine(b);

## Задание № 2.
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int value = Convert.ToInt32(Console.ReadLine());

if (value >= 9999)
{
    int c = (value % 1000);
    int result = c / 100;
    Console.WriteLine(result);


}
else
if (value >= 99)
{
    int c = value % 10;
    Console.WriteLine(" Третья цифра значения ");
    Console.WriteLine(c);
}
else
{

    Console.WriteLine("Третьей цифры нет в значении");
}

## Задание № 3.

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int DayNumbers = Convert.ToInt32(Console.ReadLine());
if (DayNumbers == 6 || DayNumbers == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (DayNumbers < 1 || DayNumbers > 7)
{
   
    Console.WriteLine("Это не день недели");
}
else
{
    Console.WriteLine("Это не выходной день");
}

## Задание №1 Третьего Семинара.

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
