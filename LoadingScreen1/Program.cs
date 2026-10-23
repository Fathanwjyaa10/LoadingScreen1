int totalSteps = 100;
int a = 1;
while (a <= totalSteps)
{
    Console.WriteLine($"Loading... Step {a} of {totalSteps}");
    if (a % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached!");
    }
    a++;
}
Console.WriteLine("\nDungeon is ready. Enter now!");