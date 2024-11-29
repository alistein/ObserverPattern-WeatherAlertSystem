using System;

namespace ObserverPattern.Interfaces;

public interface IObserver
{
	void Update(decimal stockPrice);
}
