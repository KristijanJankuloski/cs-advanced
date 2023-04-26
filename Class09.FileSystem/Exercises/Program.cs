string Calculate(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

string appPath = @"..\..\..\";
string folderPath = appPath + @"Exercise\";
string filePath = folderPath + "calculations.txt";

if (!Directory.Exists(folderPath))
    Directory.CreateDirectory(folderPath);

Console.WriteLine("Enter first number:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNum = int.Parse(Console.ReadLine());

string calculation = Calculate(firstNum, secondNum);

Console.WriteLine(calculation);

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    string output = $"{DateTime.Now}: {calculation}";
    sw.WriteLine(output);
}