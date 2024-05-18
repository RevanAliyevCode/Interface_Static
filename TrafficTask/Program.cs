// See https://aka.ms/new-console-template for more informatio
using TrafficTask;

TrafficLight trafficLight = new();
trafficLight.Color = Color.Red;
trafficLight.ChangeNextColor(); //Yellow
trafficLight.ChangeNextColor(); //Green
trafficLight.ChangeNextColor(); //Aftre reaching last color next color will be first one Red

Console.WriteLine(trafficLight.Color);
