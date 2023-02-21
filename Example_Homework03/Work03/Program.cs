// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write(" Введите число  ");
int N = Convert.ToInt32(Console.ReadLine());

int Number = 1;
Console.WriteLine("Таблица кубов чисел от 1 до введёного вами значения:");
while (Number <= N)
{
    int summ = Number * Number;
    int coube = summ * Number;
    Number++;
    Console.WriteLine(coube);


}




