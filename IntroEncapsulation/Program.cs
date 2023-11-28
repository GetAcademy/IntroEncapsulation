using System.Text;
using IntroEncapsulation;


// Pause til 10:34

Console.OutputEncoding = Encoding.UTF8;

var trafficLight = new TrafficLight();

while (true)
{
    Console.Clear();
    trafficLight.Show();
    Console.ReadKey();
    trafficLight.Next();
}