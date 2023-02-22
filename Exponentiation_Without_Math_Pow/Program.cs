// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

string Exponentiation(double x, int y)
{
    string result = "";
    double exponent = 1;
    for (int i = 1; i <= y; i++)
    {
        exponent *= x;
    }
    result = Convert.ToString(exponent);
    return result;
}

Console.WriteLine("Введите число, которое нужно возвести в степень");
double A = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите, в какую натуральную степень следует возвести число");
int B = int.Parse(Console.ReadLine());
string expo = Exponentiation(A, B);
Console.WriteLine(expo);
