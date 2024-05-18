// See https://aka.ms/new-console-template for more information
using C = Calculator;
using static System.Console;

string[] opt = { "+", "-", "*", "/" };
returnThere:
Write("Please enter operation (3 + 3): ");
string[] userInput = ReadLine().Split(' ');

if (userInput.Length != 3 || !opt.Contains(userInput[1]))
    goto returnThere;

if (int.Parse(userInput[2]) == 0 && userInput[1] == "/")
{
    WriteLine("Can not divide 0");
    goto returnThere;
}

C.Calculator calc = new(int.Parse(userInput[0]), int.Parse(userInput[2]));

switch (userInput[1])
{
    case "+":
        calc.Sum();
        break;
    case "-":
        calc.Substract();
        break;
    case "*":
        calc.Multible();
        break;
    case "/":
        calc.Divide();
        break;
    default:
        WriteLine("There is not operator like that");
        break;
}