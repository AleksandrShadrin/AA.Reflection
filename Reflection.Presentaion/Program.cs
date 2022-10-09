using Reflection.Presentaion;
using System.Reflection;

var assembly = Assembly.LoadFrom(Path.Combine(".", "Reflection.NBR.dll"));
var reflectedCalculator = new ReflectedCalculator(assembly.GetType("Reflection.NBR.Calculator"));

while (true)
{
    try
    {
        Console.Write("Введите число: ");
        var a = int.Parse(Console.ReadLine());
        reflectedCalculator.SetLeftOperand(a);
        Console.WriteLine($"Введено число: {reflectedCalculator.GetLeftOperand()}");

        Console.Write("Введите число: ");
        var b = int.Parse(Console.ReadLine());
        reflectedCalculator.SetRightOperand(b);
        Console.WriteLine($"Введено число: {reflectedCalculator.GetLeftOperand()}");

        Console.WriteLine(reflectedCalculator.Substract());
    }
    catch
    {
        Console.WriteLine("Continue? Y/N");
        if (Console.ReadLine().ToLower() != "y")
            break;
    }
}