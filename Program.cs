// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int secondDigit (int threeDigitNum)
// {
//     int seconDigitNum = threeDigitNum / 10;
//     int remainder2 = seconDigitNum % 10;
//     return remainder2;
// }

// Console.WriteLine("Enter three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = secondDigit(num);
// Console.WriteLine($"{num} the second digit -> {result}");

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int threeNum (int number)
// {
//     number %= 10;
//     return number;
// }

// Console.WriteLine("Enter number: ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if(num > 0 && num < 100)
// {
//     Console.WriteLine("there is no third digit");
// }
// if(num > 99 && num < 1000)
// {
//     int result = threeNum(num);
//     Console.WriteLine($"{num} the third num -> {result}");
// }
// if(num > 999 && num < 10000)
// {
//     int num1 = num;
//     num /= 10;
//     int result = threeNum(num);
//     Console.WriteLine($"{num1} the third num -> {result}");
// }
// if(num > 9999)
// {
//     int num1 = num;
//     num /= 100;
//     int result = threeNum(num);
//     Console.WriteLine($"{num1} the third num -> {result}");
// }

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Version 1:

// bool weekend (int numOfweek)
// {
//     if(numOfweek == 6 || numOfweek == 7) return true;
//     else return false;
// }

// Console.WriteLine("Enter a number indicating the day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} is this day of the week off? {weekend(num)}");

// Version 2:

// Console.WriteLine("Enter a number indicating the day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// while(true)
// {
//     if(num == 6 || num == 7)
//     Console.WriteLine("It's a day off");
//     else if(num > 0 && num < 6)
//     Console.WriteLine("It's a working day");
//     else 
//     Console.WriteLine("This number is not the day of the week");
//     break;
// }
