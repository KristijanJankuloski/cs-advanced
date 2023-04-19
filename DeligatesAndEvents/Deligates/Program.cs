void WriteToConsole(string text)
{
    Console.WriteLine(text);
}

void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

void saySomething(SayDelegate sayMechanisam, int counter)
{
    Console.WriteLine($"Text from {counter}");
    sayMechanisam("Kiko");
}

int AddTwoNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractTwoNumbers(int num1, int num2)
{
    return num1 - num2;
}

void PrintCalculation(CalculateDelegate calculation, int num1, int num2)
{
    Console.WriteLine(calculation(num1, num2));
}

SayDelegate sayHello = new SayDelegate(WriteToConsole);
SayDelegate sayWithRed = new SayDelegate(WriteWithRedColor);

sayWithRed("Hello there");
sayHello("Kristijan");
saySomething(WriteWithRedColor, 1);
PrintCalculation(AddTwoNumbers, 4, 5);
PrintCalculation(SubtractTwoNumbers, 5, 4);
PrintCalculation((x, y) => x * y, 4, 5);


delegate void SayDelegate(string text);
delegate int CalculateDelegate(int firstNumber, int secondNumber);