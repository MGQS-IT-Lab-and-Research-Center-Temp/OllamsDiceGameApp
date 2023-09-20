
Console.WriteLine("=====DICE GAME=====\nType 'Start' or 'S' to roll the die:");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase)  || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))

{
    Console.WriteLine("Enter 'Start' or 'S' to play the game");

return;
}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;

const int DOUBLE_POINT = 2;
const int TRIPPLE_POINT = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += TRIPPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a triple! You have a total of {totalPoint} points");
}

else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a double! You hava a total of {totalPoint} points");
}

else
{
    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou have a total of {totalPoint} points");
}

if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulations!, you have won yourself a  ballon!");
}

else if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulations!, you have just won yourself a book, Rudiment of C# by Abass Joda");
}

 else if (totalPoint == 17)
{
  Console.WriteLine("Congratulations!, you have won yourself a 5000 MAH Powerbank");  
}

 else if (totalPoint == 21)
{
    Console.WriteLine("Congratulations!, you have won yourself a  Samsung A24!");
}

 else if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulations!, you have won yourself a ticket to Silverbird Cinema!");
}

 else if (totalPoint >= 22 && totalPoint <= 24)
{
    Console.WriteLine("Congratulations!, you have won yourself all the items!");
}

else 
{
    Console.WriteLine("Sorry pls try again later!");
}