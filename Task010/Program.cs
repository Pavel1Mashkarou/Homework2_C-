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
            case "y":task(); break;
            case "n": Work = false; break;
        }
    }
}

void task()
{
    System.Console.WriteLine("Введите трёхзначное число:");
    int a = int.Parse(Console.ReadLine());
    int itog = WhatIsTheSecond(a);
    System.Console.WriteLine($"Вторая цифра числа - {itog}");
}

int WhatIsTheSecond(int number)
{
    int a = number%100;
    int b = number%10;
    number = ( a - b)/10;
    return number;

}
