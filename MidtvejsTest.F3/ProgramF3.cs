int input = Convert.ToInt32(Console.ReadLine());

if (input >= 0 && input <= 10)
{
    if (input < 5)
    {
        Console.WriteLine("Mindre end 5");
    }
    else if (input > 5)
    {
        Console.WriteLine("Større end 5");
    }
    else
    {
        Console.WriteLine("Tallet er 5");
    }
}
else
{
    Console.WriteLine("Tallet er udenfor det tilladte interval");
}