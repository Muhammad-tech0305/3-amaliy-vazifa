 using System;
 using System.Linq;

// 1-dastur
Console.WriteLine("< Bu \"TUB SONLAR\" dasturi >");

Console.Write("Biror musbat butun son kiriting:\n>>> ");
int number = Convert.ToInt32(Console.ReadLine());
int divisors = 0;

for (int index = 1; index <= number; index++)
{
    if (number % index == 0)
    {
        divisors++;
    }
}

if (divisors == 2)
{
    Console.WriteLine($"\'{number}\': tub son.");
}
else if (divisors == 1)
{
    Console.WriteLine("\'1\': tub ham emas va murakkab ham emas.");
}
else
{
    Console.WriteLine($"\'{number}\': murakkab son (tub emas).");
}

// 2-dastur
Console.WriteLine("< Bu \"BO'LUVCHISIZ SONLAR\" dasturi >");

Console.Write("Biror musbat butun son kiriting:\n>>> ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"\'{number2}\' ning 2 va 10 orasidagi bo'luvchilari: ");
for (int i1 = 2; i1 <= 10; i1++)
{
    if (number2 % i1 == 0)
    {
        Console.Write(i1 + ", ");
    }
}
Console.WriteLine(" ");

// 3-dastur
Console.WriteLine("< Bu \"DARAJA HISOBLASH\" dasturi >");

Console.Write("Biror musbat son kiriting:\n>>> ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Daraja ko'rsatkichini kiriting (butun son):\n>>> ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\'{number3}\' ning {degree}-darajasi \'{Math.Pow(number3, degree)}\' ga teng.");

// 4-dastur
Console.WriteLine("< Bu \"XARAJATLAR TO'PLAMINI HISOBLASH\" dasturi");

Console.Write("Xarjatlar ro'yxati o'lchamini kiriting: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] xarajatlar = new int[n];
Console.WriteLine("Miqdorlar ro'yxatni kiriting: ");
for (int i = 0; i < xarajatlar.Length; i++)
{
    Console.Write($"{i+1}) ");
    xarajatlar[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Sizning ro'yxatingiz:");
foreach (int xarajat in xarajatlar)
{
    Console.WriteLine(xarajat);
}
Console.WriteLine($"Umumiy yig'indi {xarajatlar.Sum()} ga teng.");

// 5-dastur
Console.WriteLine("< Bu \"ARMSTRONG SONLAR\" sonlar dasturi >");

Console.Write("Biror butun son kiriting: ");
int number5 = int.Parse(Console.ReadLine());
        
if (IsArmstrong(number5))
{
   Console.WriteLine($"\'{number5}\' armstrong son.");
}
 else
{
    Console.WriteLine($"\'{number5}\' armstrong son emas.");
}

static bool IsArmstrong(int num)
{
    int originalNum = num;
    int sum = 0;
    int digits = num.ToString().Length;
   
    while (num > 0)
    {
        int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
    }
    return sum == originalNum;
}

// 6-dastur
Console.WriteLine("< Bu \"SIFATLI BO'LUVCHILAR\" dasturi >");

Console.Write("Biror butun son kiriting: ");
int number6 = Convert.ToInt32(Console.ReadLine());
int divisors6 = 0;
Console.Write($"\'{number6}\' raqamining sifatli bo'luvchilari: ");

for (int i6 = 1; i6 < number6; i6++)
{
    if (number6 % i6 == 0)
    {
        divisors6++;
        if (divisors6 <= 4)
        {
            Console.Write($"{i6}, ");
        }
    }
}
Console.WriteLine($"\n\'{number6}\' soni \'{divisors6}\' ta bo'luvchiga ega.");
