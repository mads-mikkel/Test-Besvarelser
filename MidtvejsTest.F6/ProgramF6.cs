string firstProductName = Console.ReadLine();
decimal firstProductPrice = Convert.ToDecimal(Console.ReadLine());
string secondProductName = Console.ReadLine();
decimal secondProductPrice = Convert.ToDecimal(Console.ReadLine());

decimal totalPrice = firstProductPrice + secondProductPrice;
decimal discountPrice = firstProductPrice * 0.9m + secondProductPrice * 0.8m;

Console.WriteLine(totalPrice);
Console.WriteLine(discountPrice);