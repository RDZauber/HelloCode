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
