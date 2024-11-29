using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class Stock : ISubject
{
	private readonly List<IObserver> observers = [];
	private decimal _price;

	public decimal Price
	{
		get => _price;

		set
		{
			_price = value;
			Notify();
		}
	}

	public void Notify()
	{
		observers.ForEach(observer => observer.Update(_price));
	}

	public void Subscribe(IObserver observer)
	{
		observers.Add(observer);
	}

	public void Unsubsribe(IObserver observer)
	{
		observers.Remove(observer);
	}
}
