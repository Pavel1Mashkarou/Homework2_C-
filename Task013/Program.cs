Main();

void Main()
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = Console.ReadLine();
        switch (a)
        {
            case "y": task();break;
            case "n": Work = false; break;
        }
    }
}

void task()
{
    System.Console.WriteLine("Введите число:");
    string a = Console.ReadLine();
    string res = Magic(a);
    if (res == "В Вашем числе нету третьей цифры.") System.Console.WriteLine($"В Вашем числе {a} нету третьей цифры.");
    else System.Console.WriteLine($"Третья цифра Вашего числа {a} - {res}");
}

string Magic(string number)
{
    string a = "";
    if (number.Length < 3) a = "В Вашем числе нету третьей цифры.";
    else a = number[2].ToString();
    return a;
}
