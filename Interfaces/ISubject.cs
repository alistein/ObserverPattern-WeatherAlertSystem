using System;

namespace ObserverPattern.Interfaces;

public interface ISubject
{
	void Subscribe(IObserver observer);
	void Unsubsribe(IObserver observer);
	void Notify();
}
