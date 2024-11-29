using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class WeatherStation : ISubject
{
	private readonly List<IObserver> observers = [];
	private WeatherModel _weatherModel = default!;

	public WeatherModel WeatherModel
	{
		get => _weatherModel;

		set
		{
			_weatherModel = value;
			Notify();
		}
	}

	public void Notify()
	{
		observers.ForEach(observer => observer.Update(_weatherModel));
	}

	public void Subscribe(IObserver observer)
	{
		if (observer is AlertSystem)
		{
			observers.Insert(0, observer);
		}
		else
		{
			observers.Add(observer);
		}

	}

	public void Unsubsribe(IObserver observer)
	{
		observers.Remove(observer);
	}
}
