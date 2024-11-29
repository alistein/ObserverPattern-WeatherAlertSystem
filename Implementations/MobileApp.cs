using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class MobileApp : IObserver
{
	public void Update(decimal stockPrice)
	{
		Console.WriteLine($"MobileApp: Stock price updated to {stockPrice:C}");
	}
}
