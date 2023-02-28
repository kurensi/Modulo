try
{
    Console.Write("die zahl x:");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x % 3 == 0)
    {
        Console.WriteLine($"{x} ist dividierbar durch 3 oder 10");
    }
    else if (x % 9 == 0)
    {
        Console.WriteLine($"{x} ist durch 3 und 9 teilbar");
    }
    else
    {
        Console.WriteLine($" ist nicht durch 9 oder 3 teilbar");
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();