// See https://aka.ms/new-console-template for more information
using StaticMethods;

int[] arr = [1, 4, 5, 6];

Console.WriteLine(arr.FindAverage());

string myName = "revan";
string polindrom = "Amma";

Console.WriteLine(myName.Revrese());

Console.WriteLine(myName.CapitaliceString());

Console.WriteLine(polindrom.FindIsPolindrom());

int num = 101;

Console.WriteLine(MathUtils.IsPrime(num));