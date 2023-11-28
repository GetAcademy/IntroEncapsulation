using System.Text;
using IntroEncapsulation;

Console.OutputEncoding = Encoding.UTF8;

var trafficLight = new TrafficLight();

var showRedCount = 10;
while (showRedCount>0)
{
    Console.Clear();
    trafficLight.Show();
    if (trafficLight.IsFirstPhase)
    {
        showRedCount--;
    }
    Thread.Sleep(500);
    trafficLight.Next();
}



//var values = new Dictionary<List<string>,List<Person>>();

/*
var isRed = true;
var isYellow = false;
var isGreen = false;

while (true)
{
    Console.Clear();
    TrafficLightConsole.Write(isRed, isYellow, isGreen);

    if (isRed && !isYellow && !isGreen)
    {
        isYellow = true;
    } else if (isRed && isYellow && !isGreen) {
        isRed=false;
        isYellow = false;
        isGreen = true;
    } else if (!isRed && !isYellow && isGreen) {
        isYellow = true;
        isGreen = false;
    } else if (!isRed && isYellow && !isGreen) {
        isYellow = false;
        isRed = true;
    }

    Console.ReadKey();
}
 */