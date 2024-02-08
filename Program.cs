using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

int a = 42;
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Угадал"); 
}
else
{
    Console.WriteLine("Лучше думай. Число не подходит");
}


 int x = 2;
 int y = - 3;

if ( x > 0 && y > 0)
{
    Console.WriteLine("Данная точка в первой плокости");
} 
if (x < 0 && y > 0)
{
    Console.WriteLine("Данная точка во второй плокости");
} 
if (x < 0 && y < 0)
{
    Console.WriteLine("Данная точка в третьей плокости");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Данная точка в четвертой плокости");
}


int number = 15;
int firstDigit = number / 10;
int secondDigit = number % 10;
if ( firstDigit > secondDigit)
{
    Console.WriteLine("Первая цифра больше");
}
if (firstDigit < secondDigit)
{
    Console.WriteLine("Вторая цифра больше");
}
