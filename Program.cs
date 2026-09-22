int dayNumber = 5;
switch (dayNumber)
{
    case 6 or 7 or 5: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 101;

switch (score)
{
    case >= 0 and < 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

int score1 = 78;
string result = score1 switch
{
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко",
};
Console.WriteLine(result);