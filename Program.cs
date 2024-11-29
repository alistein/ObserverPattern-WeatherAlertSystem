// See https://aka.ms/new-console-template for more information
using ObserverPattern;
using ObserverPattern.Implementations;

WeatherStation weatherStation = new();

MobileApp mobileApp = new();
WebApp webApp = new();
AlertSystem alertSystem = new();

weatherStation.Subscribe(mobileApp);
weatherStation.Subscribe(webApp);
weatherStation.Subscribe(alertSystem);

List<WeatherModel> dummyWeathers =
[
	new WeatherModel
	{
		Temperature = 30,
		Humidity = 13,
		WindSpeed = 200
	},

	new WeatherModel
	{
		Temperature = 50,
		Humidity = 40,
		WindSpeed = 300
	},

	new WeatherModel
	{
		Temperature = 20,
		Humidity = 19,
		WindSpeed = 50
	}
];

foreach (var dummyWeather in dummyWeathers)
{
	await Task.Delay(2000);

	weatherStation.WeatherModel = dummyWeather;

	weatherStation.Unsubsribe(mobileApp);

	Console.WriteLine("------------------------------------------");
}