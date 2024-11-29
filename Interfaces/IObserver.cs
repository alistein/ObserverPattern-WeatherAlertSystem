using System;

namespace ObserverPattern.Interfaces;

public interface IObserver
{
	void Update(WeatherModel weatherModel);
}
