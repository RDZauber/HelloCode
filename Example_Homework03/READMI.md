## Задача № 1.

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



## Задача № 2.

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {segmentLength}");


## Задача № 3.

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