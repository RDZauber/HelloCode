
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
