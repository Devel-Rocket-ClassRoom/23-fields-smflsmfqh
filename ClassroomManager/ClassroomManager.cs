using System;

class ClassroomManager
{
    private const int maxCount = 5;
    private readonly string className;
    private string[] studentNames;
    private int currentCount = 0;
    private static int totalClassCount;

    public ClassroomManager(string className)
    {
        this.className = className;
        studentNames = new string[maxCount];
        totalClassCount++;
    }

    public void AddStudent(string name)
    {
        if (currentCount >= maxCount)
        {
            Console.WriteLine("정원 초과입니다.");
        }
        else
        {
            currentCount++;
            studentNames[currentCount - 1] = name;
        }
    }
    public void ShowStudents()
    {
        Console.WriteLine($"=== {className}반 학생 목록 ({currentCount}/{maxCount}) ===");
        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine($"{i + 1}. {studentNames[i]}");
        }
        Console.WriteLine();
    }
    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClassCount}");
    }
}
