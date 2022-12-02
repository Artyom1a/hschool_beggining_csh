﻿internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        // Task6();
    }
    #region Task1

    // На входе дано три массива заполненных случайными числами. Написать метод
    // по подсчёту общего количества чётных чисел в массивах. (ref)
    static void Task1()
    {
        double[] array = { 2, 4, 6, 5, 8, 9 };
        double[] array1 = { 2, 4, 6, 5, 8, 9 };
        double[] array2 = { 2, 4, 6, 5, 9 };
        double podschet = 0;
        System.Console.WriteLine(ChetNumber(array, ref podschet));
        System.Console.WriteLine(ChetNumber(array1, ref podschet));
        System.Console.WriteLine(ChetNumber(array2, ref podschet));
    }
    static double ChetNumber(double[] array, ref double podschet)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                podschet++;
            }
        }
        return podschet;
    }

    #endregion



    #region Task2
    //     Написать метод, который проверяет является ли введнная строка почтовым
    // адрессом и возвращающий домен почты. почты.(Out)
    static void Task2()
    {
        string email = "rtty@gmail.com";
        TryFalseEmail(email, out string result, out string domen);
        System.Console.WriteLine($"{domen},{result}");
    }
    static string TryFalseEmail(string email, out string result, out string domen)
    {
        domen = "";
        result = "false";
        if (email.Contains("@gmail.com"))
        {
            domen = "@gmail.com";
            result = "true";
        }
        return domen;
        return result;

    }
    #endregion
    #region Task3
    //     Написать метод , который удаляет из строки заданный символ. Символ является
    // входным параметром значением. Строка должна быть параметром ссылкой и
    // результатом. (ref)
    static void Task3()
    {
        string str = "etigkvbnvrew";
        char symbol = Convert.ToChar(Console.ReadLine());
        System.Console.WriteLine(DeleteSymbol(ref str, symbol));
    }

    static string DeleteSymbol(ref string str, char symbol)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == symbol)
            {
                str = str.Remove(i, 1);
            }
        }
        return str;
    }
    #endregion

    #region Task4
    //     Написать метод выполняющий сложение парметов, если параметры одного типа
    // данных возвращать true и результат сложение, в противном случае false (out)
    static void Task4()
    {
        object? parametr = "5";
        object? parametr1 = "16";
        ProverkaParametr(parametr, parametr1, out string itog, out string sumparametr);
        System.Console.WriteLine($"{itog},{sumparametr}");


    }
    static string ProverkaParametr(object parametr, object parametr1, out string itog, out string sumparametr)
    {
        itog = "false";
        sumparametr = "";
        int number;
        int number1;
        TypeCode typeCode = Type.GetTypeCode(parametr.GetType());
        System.Console.WriteLine(typeCode);
        if (parametr is string && parametr1 is string)
        {
            sumparametr += parametr;
            sumparametr += parametr1;
            itog = "true";
        }
        else if (parametr is int && parametr1 is int)
        {
            number = Convert.ToInt32(parametr);
            number1 = Convert.ToInt32(parametr1);
            int sumnumber = number + number1;
            sumparametr += Convert.ToString(sumnumber);
            itog = "true";
        }
        return sumparametr;
        return itog;
    }
    #endregion
    #region Task5
    //     Пользователь вводит строку и разделитель. Написать метод возвращающий
    // наличие в строке разделителя, если разделитель есть вернуть строку разбитую
    // данным разделителем ( out)
    static void Task5()
    {
        System.Console.WriteLine("Task5");
        string? str = Console.ReadLine();
        string? razd = Console.ReadLine();
        if (!string.IsNullOrEmpty(str) && !string.IsNullOrEmpty(razd))
        {
            System.Console.WriteLine(ProverkaNaRazd(str, razd, out string str1));
        }
    }
    static string ProverkaNaRazd(string str, string razd, out string str1)
    {
        str1 = "";
        if (str.Contains(razd))
        {
            str1 = string.Join(' ', str.Split(razd));
        }
        return str1;
    }
    #endregion
}