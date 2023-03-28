Main();

void Main()
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = Console.ReadLine();
        switch(a)
        {
            case "y": Osn();break;
            case "n": Work = false; break;
        }
    }
}

void Osn()
{
    System.Console.WriteLine("Введите номер дня:");
    int a = int.Parse(Console.ReadLine());
    int res = Check(a);
    if (res == 0) System.Console.WriteLine("День рабочий");
    if (res == 2) System.Console.WriteLine("День выходной");
    if (res == -1) System.Console.WriteLine("Нет такого дня в неделе. В неделе всего 7 дней.");

}

int Check(int number)
{
    int a = 0;
    if (number<6 && number>0) a = 0;
    if (number<0 || number>7) a = -1;
    if (number==6 || number== 7) a = 2;
    return a;
}