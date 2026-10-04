// using System.Text.RegularExpressions;

// int totalExercises = 8;

// for (int number = totalExercises; number >= 1; number--) 
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("_");
// }

// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue;
//     }
//     Console.WriteLine($"Пропущенные билеты: {count}");
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     break;
// }

// for (; ; )
// {
//     Console.Write("Введите код группы (для входа - 'выход') ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");

// Задача А

// using System.Globalization;

// int N = 17;

// for (int number = 1; number <= N; number++)
// {
//     if (number % 2 != 0)
//     {
//         Console.WriteLine(number);
//     }
// }

// // Задача Б

// for (int number1 = 100; number1 >= 0; number1 -= 10)
// {
//     Console.WriteLine(number1);
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
// 
// Вариант 7

for (int a = 1; a <= 5; a++)
{
    for (int b = 1; b <= 5; b++)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}

Console.WriteLine();
// Вариант 10
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        if (i + j == 6)
        {
            Console.WriteLine($"{i}, {j}");
            break;
        }
    }
}
