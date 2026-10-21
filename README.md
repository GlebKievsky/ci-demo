# ci-demo

Учебный репозиторий к лекции «Автоматизация и CI/CD с GitHub Actions».

Маленький проект на C#: библиотека переводит баллы (0–100) в оценку по пятибалльной шкале, тесты на xUnit проверяют её.

| Папка | Что внутри |
|---|---|
| `src/Grades` | библиотека `GradeCalculator` |
| `src/Grades.App` | консольная программа `gradecalc` |
| `tests/Grades.Tests` | тесты xUnit |

```bash
dotnet build
dotnet test
dotnet run --project src/Grades.App
```
