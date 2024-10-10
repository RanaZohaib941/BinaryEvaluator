// See https://aka.ms/new-console-template for more information
using BinaryEvaluator;
while (true)
{
    Console.WriteLine("Please enter the binary number and I will tell you whether it is good or not or write exit to close");
    var binaryString = Console.ReadLine();
    if (binaryString?.ToLower() == "exit")
    {
        Environment.Exit(0);
    }
    else if (BinaryEvaluatorClass.IsBinaryString(binaryString))
    {
        Console.WriteLine(BinaryEvaluatorClass.ValidateBinaryString(binaryString));
    }
    else 
    {
        Console.WriteLine($"{binaryString} is not a binary number");
        continue; 
    }
}
        