using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class WebApp : IObserver
{
	public void Update(decimal stockPrice)
	{
		Console.WriteLine($"WebApp: Stock price updated to {stockPrice:C}");
	}
}
