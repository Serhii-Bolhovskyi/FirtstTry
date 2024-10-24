Console.Write("Введіть день тижня: ");
int day;
if (int.TryParse(Console.ReadLine(), out day) == false)
{
    Console.WriteLine("Введено некоретні дані");
    return;
}

switch (day)
{
    case 1: Console.WriteLine("Понеділок");
        break;
    case 2: Console.WriteLine("Вівторок");
        break;  
    case 3: Console.WriteLine("Середа");
        break;
    case 4: Console.WriteLine("Четвер");
        break; 
    case 5: Console.WriteLine("Пʼятниця");
        break;
    case 6: Console.WriteLine("Субота");
        break;
    case 7: Console.WriteLine("Неділя");
        break;
    default: Console.WriteLine("Не існує такий день тижня");
        break;
}