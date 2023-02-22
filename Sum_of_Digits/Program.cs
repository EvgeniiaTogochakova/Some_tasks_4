// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

string SumOf2Digits(int a)
{
    string result1 = "";
    int result_inter1 = a / 10;
    int result_inter2 = a % 10;
    int sum1 = result_inter1 + result_inter2;
    string sum11 = Convert.ToString(sum1);
    result1 += sum11;
    return result1;
}

string SumOf3Digits(int b)
{
    string result2 = "";
    int result_inter3 = b / 100;
    int result_inter4 = (b / 10) % 10;
    int result_inter5 = b % 10;
    int sum2 = result_inter3 + result_inter4 + result_inter5;
    string sum22 = Convert.ToString(sum2);
    result2 += sum22;
    return result2;
}

string SumOf4Digits(int c)
{
    string result3 = "";
    int result_inter6 = c / 1000;
    int result_inter7 = (c / 100) % 10;
    int result_inter8 = (c / 10) % 10;
    int result_inter9 = c % 10;
    int sum3 = result_inter6 + result_inter7 + result_inter8 + result_inter9;
    string sum33 = Convert.ToString(sum3);
    result3 += sum33;
    return result3;
}

Console.WriteLine("Введите число из двух, трех или четырех знаков");
int n = int.Parse(Console.ReadLine());
if ((n >= 10) && (n < 10000))
{
    if ((n >= 10) && (n < 100))
    {
        string s1 = SumOf2Digits(n);
        Console.WriteLine(s1);
    }

    else if ((n >= 100) && (n < 1000))
    {
        string s2 = SumOf3Digits(n);
        Console.WriteLine(s2);
    }

    else if ((n >= 1000) && (n < 10000))
    {
        string s3 = SumOf4Digits(n);
        Console.WriteLine(s3);
    }
}
else Console.WriteLine("К сожалению, это не число из двух, трех или четырех знаков, повторите ввод числа!");




