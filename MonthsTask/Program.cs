// See https://aka.ms/new-console-template for more information
using MonthsTask;
using static System.Console;

Write("Enter month with number (1-12): ");
int num = int.Parse(ReadLine());


Write($"{(Months)num} is ");
switch (num)
{
    case (int)Months.January:
    case (int)Months.February:
    case (int)Months.December:
        WriteLine("Winter season");
        break;
    case (int)Months.March:
    case (int)Months.April:
    case (int)Months.May:
        WriteLine("Spring season");
        break;
    case (int)Months.June:
    case (int)Months.July:
    case (int)Months.August:
        WriteLine("Summer season");
        break;
    case (int)Months.September:
    case (int)Months.October:
    case (int)Months.Novomber:
        WriteLine("Autumn season");
        break;
    default:
        WriteLine("There is not a month like that");
        break;
}