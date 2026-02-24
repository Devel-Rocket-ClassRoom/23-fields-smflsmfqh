using System;

// 1
{
    Player1 player = new Player1();
    player.ShowStatus();
    Console.WriteLine();
}

// 2
{
    Character1 player = new Character1();
    player.name = "용사";
    player.health = 10;
    Console.WriteLine($"{player.name}\n{player.health}");
    Console.WriteLine();
}

// 3
{
    Character2 player = new Character2();
    player.SetInfo("용사", 10);
    player.ShowInfo();
    Console.WriteLine();
}

// 4
{
    Player2 player = new Player2();
    player.ShowStatus();
    Console.WriteLine();
}

// 5
{
    Say hello = new Say();
    hello.Hi();
    Console.WriteLine();
}

// 6
{
    Schedule weekDays = new Schedule();
    weekDays.PrintWeekDays();
    Console.WriteLine();
}

// 7
{
    DefaultValues defaultValues = new DefaultValues(); 
    defaultValues.ShowDefaults();
    Console.WriteLine();

}

// 8
{
    Counter counter1 = new Counter();
    Counter counter2 = new Counter();
    Counter counter3 = new Counter();
    Console.WriteLine();
}

// 9
{
    Player3 player1 = new Player3("용사");
    Player3 player2 = new Player3("마법사");
    Player3 player3 = new Player3("궁수");

    Console.WriteLine($"{player1.name}");
    Console.WriteLine($"{player2.name}");
    Console.WriteLine($"{player3.name}");
    Console.WriteLine($"총 플레이어 수: {Player3.totalCount}");
    Console.WriteLine();
}

// 10
{
    GameConfig gameConfig = new GameConfig();
    gameConfig.ShowConfig();
    Console.WriteLine();
}

// 11
{
    Example ex = new Example();
    ex.ShowValues();
    Console.WriteLine();
}

// 12
{
    Player4 player = new Player4();
    player.SetInfo("용사", 10);
    player.ShowInfo();
    Console.WriteLine();
}

// 13
{
    Person person = new Person();
    person.ShowProfile();
    Console.WriteLine();
}

// 14
{
    GameCharacter player1 = new GameCharacter("용사", 15);
    GameCharacter player2 = new GameCharacter("마법사", 25);
    player1.ShowInfo();
    player2.ShowInfo();
    player1.TakeDamage(30);
    player1.TakeDamage(50);
    player1.TakeDamage(50);
    Console.WriteLine();
    GameCharacter.ShowTotalCouont();


}

// --- class 생성 ---

// 1
class Player1
{
    string name;
    int health;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}");
    }
}

//2
class Character1
{
    public string name;
    public int health;
  
}

// 3
class Character2
{
    private string name;
    private int health;

    public void SetInfo(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}");
    }
}

// 4
class Player2
{
    string name = "이름없음";
    int health = 100;
    int level = 1;
    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}\n레벨: {level}");
    }

}

// 5
class Say
{
    private string message = "안녕하세요";

    public void Hi()
    {
        message = "반갑습니다";
        Console.WriteLine(message); 
    }
}

// 6
class Schedule
{
    private string[] week;

    public Schedule()
    {
        week = new[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
    }
    public void PrintWeekDays()
    {
        Console.WriteLine(string.Join("\t", week));
    }
}

// 7
class DefaultValues
{
    private int number;
    private bool flag;
    private string text;

    public void ShowDefaults()
    {
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"flag: {flag}");
        Console.Write($"text: ");
        if (text == null) { Console.WriteLine("null"); }
        else Console.WriteLine(text);
       
    }
}

// 8
class Counter
{
    public static int count;
    public Counter()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }
}

// 9
class Player3
{
    public string name;
    public static int totalCount;

    public Player3(string name )
    {
        this.name = name;
        totalCount++;
    }
}

// 10
class GameConfig
{
    private readonly string version = "1.0.0";
    private int maxPlayers;

    public GameConfig()
    {
        maxPlayers = 4;
    }
    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}\n최대 플레이어: {maxPlayers}");
    }
}

// 11
class Example
{
    private const double Pi = 3.14159;
    private readonly DateTime createdAt = DateTime.Now;

    public void ShowValues()
    {
        Console.WriteLine($"원주율: {Pi}\n생성 시간: {createdAt}");
    }
}

// 12
class Player4
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}\n레벨: {level}");
    }
}

// 13
class Person
{
    private const string name = "홍길동";
    private readonly int age = 21;
    private readonly string alias = "길동이";
    private string[] sites = new[] {"네이버", "구글"};

    public void ShowProfile()
    {
        Console.WriteLine($"이름 : {name}\n나이: {age}\n닉네임: {alias}\n사이트: {string.Join(", ", sites)}");
    }

}

// 14
class GameCharacter
{
    private readonly string name;
    private const int maxHealth = 100;
    private const int minHealth = 0;
    private int currentHealth;
    private int attackPower;
    private static int totalCharacter;

    public GameCharacter(string name, int attackPower)
    {
        this.name = name;
        this.attackPower = attackPower;
        currentHealth = maxHealth;
        totalCharacter++;
    }

    public void TakeDamage(int demage)
    {
        currentHealth -= demage;
        if (currentHealth < minHealth)
        {
            currentHealth = 0;
        }
        Console.WriteLine($"{name}이(가) {demage} 데미지를 받음! 남은 체력: {currentHealth}");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {currentHealth}/{maxHealth}");
        Console.WriteLine($"공격력: {attackPower}");
        Console.WriteLine();
    }
    public static void ShowTotalCouont()
    {
        Console.WriteLine($"총 캐릭터 수: {totalCharacter}");
    }
}