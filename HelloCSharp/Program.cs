Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    total += 2;
}
else if (roll1 == roll2 && roll1 == roll3)
{
    total += 6;
}

Console.WriteLine($"Updated total: {total}");
if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}