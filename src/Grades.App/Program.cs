using Grades;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введи баллы (0–100): ");

if (int.TryParse(Console.ReadLine(), out int points) && points >= 0 && points <= 100)
    Console.WriteLine($"Оценка: {GradeCalculator.ToGrade(points)}");
else
    Console.WriteLine("Нужно целое число от 0 до 100.");
