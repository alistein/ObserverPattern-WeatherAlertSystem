using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class MobileApp : IObserver
{
	public void Update(WeatherModel weatherModel)
	{
		Console.WriteLine($"MobileApp: Current temprature is: {weatherModel.Temperature}°C");
	}
}
