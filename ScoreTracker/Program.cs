using System;

ScoreTracker course1 = new ScoreTracker("수학");
course1.ShowScore();
course1.SetScore(85);
course1.AddBonus(10);
course1.AddBonus(20);
course1.SetScore(101);
Console.WriteLine();
course1.ShowScore();

