﻿// 1. Пользователь вводит границы интервала из которого программа загадывает число.
// Написать программу про поиску данного числа. Пользователь пишит число в консоль,
// программа отвечает
System.Console.WriteLine("Задача 1");
System.Console.WriteLine("Введите интервал числа, программа выберет число из этого интервала, вам нужно будет угадать его");
object? ifnumber1 = Console.ReadLine();
object? ifnumber2 = Console.ReadLine();
int number1 = Convert.ToInt32(ifnumber1);
int number2 = Convert.ToInt32(ifnumber2);
int slucnumber = new Random().Next(number1, number2);
int number3;
do
{
    System.Console.WriteLine("Введите число, которое загадала програма");
    number3 = Convert.ToInt32(Console.ReadLine());
    if (slucnumber == number3)
    {
        break;
    }
}
while (true);
{
    System.Console.WriteLine("Вы угадали");
}

// 2.Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и
// остальных символов.
// ввод
// на массив строки
System.Console.WriteLine("Задача 2");
System.Console.WriteLine("Введите строку");
string? str = Console.ReadLine();
int symbol = 0;
int letter = 0;
int whitespace = 0;
int isnumber1 = 0;
for (int index = 0; index < str.Length; index++)
{
    if (Char.IsSymbol(str[index]))
    {
        symbol += 1;
    }
    else if (char.IsLetter(str[index]))
    {
        letter += 1;
    }
    else if (char.IsWhiteSpace(str[index]))
    {
        whitespace += 1;
    }
    else if (char.IsNumber(str[index]))
    {
        isnumber1 += 1;
    }
}
System.Console.WriteLine($"{symbol}-символы,{letter}-буквы, {whitespace}-пробелы, {isnumber1}-цифры");

// если остальные символы имеется ввиду не специальные, то тогда 2 вариант

System.Console.WriteLine("Задача 2, 2 вариант");
System.Console.WriteLine("Введите строку");
string? str1 = Console.ReadLine();
int symbol1 = 0;
int letter1 = 0;
int whitespace1 = 0;
int isnumber = 0;
for (int index = 0; index < str1.Length; index++)
{
    if (char.IsLetter(str1[index]))
    {
        letter1 += 1;
    }
    else if (char.IsWhiteSpace(str1[index]))
    {
        whitespace1 += 1;
    }
    else if (char.IsNumber(str1[index]))
    {
        isnumber += 1;
    }
    else if (!char.IsLetter(str1[index]) && !char.IsWhiteSpace(str1[index]) && !char.IsNumber(str1[index]))
    {
        symbol1 += 1;
    }
}
System.Console.WriteLine($"{symbol1}-символы,{letter1}-буквы, {whitespace1}-пробелы, {isnumber}-цифры");

// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в
// массив и вывести через символ, который кажет пользователь.

System.Console.WriteLine("Задача 3");
System.Console.WriteLine("Введите строку");
string? stroka = Console.ReadLine();
System.Console.WriteLine("Введите символ, который будем искать");
char? symbol = Convert.ToChar(Console.ReadLine());
string[] array = { };
string indexsymbol = "";
if (!string.IsNullOrEmpty(stroka))
{
    for (int index3 = 0; index3 < stroka.Length; index3++)
    {
        if (symbol == stroka[index3])
        {
            indexsymbol = String.Concat($"{indexsymbol}", Convert.ToString(index3), ",");
        }
    }
    System.Console.WriteLine(indexsymbol);
    array = indexsymbol.Split(',');
}
else { System.Console.WriteLine("Налл или пустота"); }

// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда
// Фиббоначи. Вывести весь этот ряд записанный в массив.
System.Console.WriteLine("Задача 4");
System.Console.WriteLine("Введите индекс последнего лемента ряда Фиббоначи");
int? indexmassivend = Convert.ToInt32(Console.ReadLine());
string Fib = "";

int element0 = 0;
int element1 = 1;
int elementx;

if (indexmassivend == 0)
{
    Fib = String.Concat($"{element0}", ",");
}
if (indexmassivend == 1)
{
    Fib = String.Concat($"{element0}", ",", $"{element1}");
}
if (indexmassivend > 1)
{
    Fib = String.Concat($"{element0}", ",", $"{element1}");
    for (int index4 = 2; index4 <= indexmassivend; index4++)
    {
        System.Console.WriteLine(Fib[index4 - 2]);
        System.Console.WriteLine(Fib[index4]);
        elementx = Convert.ToInt32(Fib[index4 - 2]) + Convert.ToInt32(Fib[index4 - 1]);
        System.Console.WriteLine(elementx);
        Fib += elementx;
        Fib += ",";
    }
}
