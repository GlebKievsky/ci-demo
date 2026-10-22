namespace Grades;

public static class GradeCalculator
{
    // Переводит баллы (0–100) в оценку по пятибалльной шкале
    public static int ToGrade(int points)
    {
        if (points < 0 || points > 100)
            throw new ArgumentOutOfRangeException(nameof(points), "Баллы должны быть от 0 до 100");

        if (points >= 90) return 5;
        if (points >= 75) return 4;
        if (points >= 60) return 3;
        return 2;
    }

    // Средний балл; для пустого списка — 0
    public static double Average(IReadOnlyList<int> points)
    {
        if (points.Count == 0) return 0;

        int sum = 0;
        foreach (int p in points) sum += p;
        return sum / points.Count;
    }
}
