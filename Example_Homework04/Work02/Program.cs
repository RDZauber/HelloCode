//Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


 int data(string text)
{
    System.Console.Write(text);
    string numbers = System.Console.ReadLine();
    int result = int.Parse(numbers);
    return result;

}

int SumAll(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int number = data("Введите число: ");
System.Console.WriteLine($" Сумма всех чисел, числа {number} = {SumAll(number)}");
