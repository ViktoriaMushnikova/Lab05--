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

string role = "teacher";

string result1 = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" => "Ограниченный доступ"
};
Console.WriteLine(result1);

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18 when !hasTicket:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

int level = 2;
switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

Console.WriteLine("Вариант А. Время года.");
int month = 9;
switch (month)
{
    case 12 or 1 or 2:
        Console.WriteLine("Зима");
        break;
    case 3 or 4 or 5:
        Console.WriteLine("Весна"); break;
    case 6 or 7 or 8:
        Console.WriteLine("Лето");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Неверный месяц");
        break;
}

Console.WriteLine("Вариант Б. Категория возраста.");
int year = 1;
string result2 = year switch
{
    < 0 => "Ошибка",
    >= 0 and <= 6 => "Ребёнок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 65 => "Пенсионер",
};
Console.WriteLine(result2);

Console.WriteLine("Индивидуальные задания");
Console.WriteLine("Вариант 3");
string day = "пятница";
string result3 = day switch
{
    "понедельник" or "вторник" or "среда" or "четверг" or "пятница" => "9:00-21:00",
    "суббота" => "10:00-20:00",
    "воскресенье" => "10:00-18:00",
    _ => "День не распознан"
};
Console.WriteLine(result3);


Console.WriteLine("Вариант 8");
string car = "автобус";
string result4 = car switch
{
    "автобус" => "Наземный транспорт",
    "метро" => "Подземный транспорт",
    "такси" => "индивидуальный транспорт",
    _ => "Неизвестный транспорт"
};
Console.WriteLine(result4);