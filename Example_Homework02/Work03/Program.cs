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

