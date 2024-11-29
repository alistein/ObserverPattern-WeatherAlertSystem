// See https://aka.ms/new-console-template for more information
using ObserverPattern.Implementations;
using ObserverPattern.Interfaces;

Stock stock = new Stock();

IObserver webApp = new WebApp();
IObserver mobile = new MobileApp();

stock.Subscribe(webApp);
stock.Subscribe(mobile);

stock.Price = 20.50m;
stock.Price = 30.50m;
stock.Price = 60.70m;

stock.Unsubsribe(mobile);

stock.Price = 80.50m;
