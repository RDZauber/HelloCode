// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int data(string text)
{
    System.Console.Write(text);
    string numbers = System.Console.ReadLine();
    int result = int.Parse(numbers);
    return result;

}

int Mult(int basis, int degree)
{
    int mult = 1;
    for (int i = 0; i < degree; i++)
    {
        mult *= basis;
    }
    return mult;
}
int basis = data("Введите основание: ");
int degree = data(" Введите показатель: ");

System.Console.WriteLine(Mult(basis, degree));