int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int addition = firstNumber + secondNumber + thirdNumber; 
int subtraction = firstNumber - secondNumber - thirdNumber; 
int multiplication = firstNumber * secondNumber * thirdNumber;

Console.WriteLine($"+: {addition}");
Console.WriteLine($"-: {subtraction}");
Console.WriteLine($"*: {multiplication}");