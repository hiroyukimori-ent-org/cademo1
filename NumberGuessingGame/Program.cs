using System;

Console.WriteLine("数当てゲーム（Number Guessing Game）");
Console.WriteLine("1から100の間の数字を当ててください。");
Console.WriteLine("0を入力すると終了します。");
Console.WriteLine();

Random random = new Random();
int targetNumber = random.Next(1, 101); // 1から100の範囲
bool gameRunning = true;

while (gameRunning)
{
    Console.Write("数字を入力してください (1-100, 0で終了): ");
    string? input = Console.ReadLine();
    
    // 入力の検証
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("無効な入力です。1から100の間の整数を入力してください。");
        continue;
    }
    
    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("無効な入力です。1から100の間の整数を入力してください。");
        continue;
    }
    
    // 0が入力された場合の終了処理
    if (guess == 0)
    {
        Console.WriteLine("残念でした。さようなら");
        gameRunning = false;
        continue;
    }
    
    // 範囲外の数値チェック
    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("範囲外です。1から100の間の整数を入力してください。");
        continue;
    }
    
    // 数字の比較とフィードバック
    if (guess == targetNumber)
    {
        Console.WriteLine($"正解です！答えは {targetNumber} でした。");
        Console.WriteLine("おめでとうございます！");
        gameRunning = false;
    }
    else if (guess < targetNumber)
    {
        Console.WriteLine("もっと大きい数字です。");
    }
    else
    {
        Console.WriteLine("もっと小さい数字です。");
    }
}
