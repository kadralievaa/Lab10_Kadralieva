// // 1
// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine($"Всего букв: {subject.Length}");

// // 2
// Console.WriteLine();
// int[] grades = { 4, 5, 3, 5, 4 };

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// // 4
// Console.WriteLine();
// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// // 5
// Console.WriteLine();
// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задача А
// Console.WriteLine();
// int[] arrayA = { 10, 20, 30, 40, 50 };
// int sumA = 0;

// foreach (int x in arrayA)
// {
//     Console.WriteLine(x);
//     sumA += x;
// }
// Console.WriteLine($"Сумма: {sumA}");

// // Задача Б
// Console.WriteLine();
// string[] daysB = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in daysB)
// {
//     Console.WriteLine($"{day}!");
// }

// // Индивидуальный вариант
// Console.WriteLine();
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine().Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 5
Console.WriteLine();
Console.WriteLine("Вариант 5:");

string[] books = { "Война и мир", "Преступление и наказание", "Мастер и Маргарита", "Евгений Онегин" };
string searchWord = "Мастер и Маргарита";

bool found = false;

foreach (string book in books)
{
    if (book == searchWord)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine("Найдено");
}
else
{
    Console.WriteLine("Не найдено");
}

// Вариант 6
Console.WriteLine();
Console.WriteLine("Вариант 6:");

int[] scores = { 15, 42, 8, 27, 63, 34, 19 };

int maxScore = scores[0];
int minScore = scores[0];

foreach (int score in scores)
{
    if (score > maxScore)
    {
        maxScore = score;
    }
    if (score < minScore)
    {
        minScore = score;
    }
}

Console.WriteLine($"Максимум: {maxScore}");
Console.WriteLine($"Минимум: {minScore}");