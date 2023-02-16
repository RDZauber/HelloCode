## Первый пример задачи нахождения максимума из 9-ти чисел:

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 23;
int c2 = 33;

int a3 = 13;
int b3 = 24;
int c3 = 33;

int max = a1;
if (b1>max) max= b1;
if (c1>max) max= c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);

## Второй пример кода той-же задачи.

    int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 200;
int c2 = 33;

int a3 = 13;
int b3 = 232;
int c3 = 33;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);


Console.WriteLine(max);

# Пример нахождения максимального числа из девяти с помощью массива.

//              0   1   2   3   4   5   6   7   8
int[] array = {12, 32, 34, 46, 25, 881, 96, 14, 92};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
 
Console.WriteLine(result);

# Поиск массива по значению элемента.

int[] array = { 10, 32, 53, 64, 25, 16, 44, 64 };

int n = array.Length;
int find = 64;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}


# Описание метода который выводит все элементы по порядку.




