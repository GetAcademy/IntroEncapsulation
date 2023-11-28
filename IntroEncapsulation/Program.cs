using System.Text;
using IntroEncapsulation;

Console.OutputEncoding = Encoding.UTF8;

// Pause til 11:05

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