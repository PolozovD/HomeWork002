// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int secondDigit (int threeDigitNum)
{
    int seconDigitNum = threeDigitNum / 10;
    int remainder2 = seconDigitNum % 10;
    return remainder2;
}

Console.WriteLine("Enter three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = secondDigit(num);
Console.WriteLine($"{num} the second digit -> {result}");
