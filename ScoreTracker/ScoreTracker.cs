using System;

class ScoreTracker
{
    private const int maxScore = 100;
    private const int minScore = 0;
    private readonly string courseName;
    private int currentScore = 0;
    private int bonusCount = 0;

    public ScoreTracker(string courseName)
    {
        this.courseName = courseName;
    }

    public void SetScore(int score)
    {
        if (score > maxScore || score < minScore)
        {
            Console.WriteLine("점수는 0~100 사이여야 합니다.");
        }
        else
        {
            currentScore = score;
            Console.WriteLine($"점수를 {currentScore}로 설정했습니다.");
        }
    }
    public void AddBonus(int bonus)
    {
        currentScore += bonus;
        if (currentScore > maxScore)
        {
            currentScore = maxScore;
        }
        bonusCount++;
        Console.Write($"{bonus}점 보너스 적용! 현재 점수: {currentScore} ");
        if (currentScore == maxScore) Console.WriteLine("(최대 점수 도달)");
        Console.WriteLine();
     
    }
    public void ShowScore()
    {
        Console.WriteLine($"=== {courseName} ===");
        Console.WriteLine($"점수: {currentScore}/{maxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonusCount}");
        Console.WriteLine();
    }
}
