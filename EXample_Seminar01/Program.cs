// Напишите программу, которая на вход принемает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.WriteLine("START");
int N;

Console.WriteLine("Введите N");

N = 5;

int index;
index = -N;

while (index <= N)
{
    Console.Write(index + " ");
    index = index + 1;

}

Console.WriteLine("END");