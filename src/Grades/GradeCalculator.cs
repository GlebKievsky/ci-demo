namespace Grades;

public static class GradeCalculator
{
    // Переводит баллы (0–100) в оценку по пятибалльной шкале
    public static int ToGrade(int points)
    {
        if (points < 0 || points > 100)
            throw new ArgumentOutOfRangeException(nameof(points), "Баллы должны быть от 0 до 100");

        if (points > 90) return 5;
        if (points >= 75) return 4;
        if (points >= 60) return 3;
        return 2;
    }
}
