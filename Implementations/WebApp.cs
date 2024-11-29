using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations;

public class WebApp : IObserver
{
	List<WeatherModel> weatherModels = [];

	public void Update(WeatherModel weatherModel)
	{
		weatherModels.Add(weatherModel);

		Console.WriteLine($"""

							WebApp Trend:

							Current Temperature: {weatherModel.Temperature}°C
							Current Humidty: {weatherModel.Humidity}%
							Current Wind Speed: {weatherModel.WindSpeed} km/h

							Average Temperature: {Math.Floor(weatherModels.Average(wm => wm.Temperature))}°C
							""");
	}
}
