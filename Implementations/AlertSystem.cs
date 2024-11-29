using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class AlertSystem : IObserver
{
	public void Update(WeatherModel weatherModel)
	{
		if (weatherModel.Temperature is > 40 or < 0)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("**Alert System: EXTREME TEMPERATURE BE SAFE**");
			Console.ForegroundColor = ConsoleColor.White;
		}

		else if (weatherModel.WindSpeed >= 100)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("**Alert System: HIGH WIND SPEED**");
			Console.ForegroundColor = ConsoleColor.White;
		}

		else
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("**Alert System: NO PROBLEM DETECTED**");
			Console.ForegroundColor = ConsoleColor.White;
		}

	}
}
