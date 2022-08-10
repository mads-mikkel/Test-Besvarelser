bool done = false;
List<string> productNames = new();
List<decimal> productPrices = new();

while (!done)
{
    Console.WriteLine("\n1. Indtast varer\n2. Udregn total\n3. Afslut");
    string input = Console.ReadLine();
    if (input == "1")
    {
        bool inputDone = false;
        while (!inputDone)
        {
            Console.WriteLine("Tast STOP for at afslutte indtastning.\nIndtast varenavn: ");
            string productName = Console.ReadLine();

            if (productName == "STOP")
            {
                inputDone = true;
            }
            else
            {
                Console.WriteLine("Indtast pris: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                productNames.Add(productName);
                productPrices.Add(price);
            }
        }
    }
    else if (input == "2")
    {
        // Vis det hele:
        Console.WriteLine("Vare\t\tPris");
        decimal totalPrice = default;
        for (int i = 0; i < productNames.Count; i++)
        {
            totalPrice += productPrices[i];
            string output = $"{productNames[i]}\t\t{productPrices[i]:C2}";
            Console.WriteLine(output);
        }
        Console.WriteLine($"Total:\t\t{totalPrice:C2}");

        Console.WriteLine("Tast en tast for at vende tilbage til menuen...");
        Console.ReadLine();
    }
    else if (input == "3")
    {
        done = true;
    }
    else
    {
        Console.WriteLine("Du har ikke indtastet et gyldigt valg. Prøv igen.");
    }
}

Console.WriteLine("Farvel");